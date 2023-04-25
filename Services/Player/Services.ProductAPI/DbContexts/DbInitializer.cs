using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Services.ProductAPI.DbContexts
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext db, IConfiguration configuration)
        {
            db.Database.EnsureCreated();
            if (db.Players.Any())
            {
                return;   // DB has been seeded
            }

            NpgsqlConnection conn = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            NpgsqlCommand cmd = new NpgsqlCommand();
            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), "PlayersSeedData.csv");
            string tableName = "player";
            Boolean result = true;

            try
            {
                conn.Open();
                NpgsqlTransaction transaction = conn.BeginTransaction();

                if (File.Exists(filePath))
                {
                    try
                    {
                        using (var writer = conn.BeginTextImport("COPY " + tableName + " FROM STDIN"))
                        {
                            foreach (String sLine in File.ReadAllLines(filePath))
                            {
                                writer.WriteLine(sLine);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        result = false;
                        transaction.Rollback();

                        throw e;
                    }
                    finally
                    {
                        if (result)
                        {
                            transaction.Commit();
                        }

                        transaction.Dispose();
                    }
                }              
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                cmd.Dispose();

                conn.Close();
                conn.Dispose();
            }

        }
    }
}

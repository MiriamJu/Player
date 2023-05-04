using Microsoft.Extensions.Configuration;
using Npgsql;
using Services.PlayerAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Services.PlayerAPI.DbContexts
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

            
            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), "PlayersSeedData.csv");
           
            List<Player> players = new List<Player>();
            List<BirthStatusAdditionalData> birthStatusAdditionals = new List<BirthStatusAdditionalData>();
            List<DeathStatusAdditionalData> deathStatusAdditionals = new List<DeathStatusAdditionalData>();
            DeathStatusAdditionalData deathModel = new DeathStatusAdditionalData();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                //playerCsv.AppendLine("PlayerId,NameFirst ,NameLast ,NameGiven,Weight,Bats,Throws,DebutFinalGame,RetroId,DdRefId");
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(',');

                    var playerID = values[0];
                    var birthYear = values[1];
                    var birthMonth = values[2];
                    var birthDay = values[3];
                    var birthCountry = values[4];
                    var birthState = values[5];
                    var birthCity = values[6];
                    var deathYear = values[7];
                    var deathMonth = values[8];
                    var deathDay = values[9];
                    var deathCountry = values[10];
                    var deathState = values[11];
                    var deathCity = values[12];
                    var nameFirst = values[13];
                    var nameLast = values[14];
                    var nameGiven = values[15];
                    var weight = values[16];
                    var height = values[17];
                    var bats = values[18];
                    var throws = values[19];
                    var debut = values[20];
                    var finalGame = values[21];
                    var retroID = values[22];
                    var bbrefID = values[23];

                    Player playerModel = new Player() { PlayerId = playerID, NameFirst = nameFirst, NameGiven = nameGiven, NameLast = nameLast, Weight = (!string.IsNullOrEmpty(weight) ? int.Parse(weight) : null), Height = (!string.IsNullOrEmpty(height) ? int.Parse(height) : null), Bats = bats, DdRefId = bbrefID, RetroId = retroID, FinalGame = new DateTime() };
                    BirthStatusAdditionalData birthModel = new BirthStatusAdditionalData() { Id = Guid.NewGuid(), PlayerId = playerID, City = birthCity, Country = birthCountry, State = birthState, status = Models.Enums.LifeStatus.Birth };
                 
                    HandleNullableFields(deathModel, birthYear, birthMonth, birthDay, deathYear, deathMonth, deathDay, birthModel);
                    if (!string.IsNullOrEmpty(deathDay))
                    {
                        deathModel = new DeathStatusAdditionalData() { Id = Guid.NewGuid(), PlayerId = playerID, City = deathCity, Country = deathCountry, State = deathState, status = Models.Enums.LifeStatus.Death };
                        deathStatusAdditionals.Add(deathModel);
                    }
                    players.Add(playerModel);
                    birthStatusAdditionals.Add(birthModel);


                }
                //after your loop
                using (ApplicationDbContext context = db)
                {
                    db.Players.AddRange(players);
                    db.BirthStatusAdditionalData.AddRange(birthStatusAdditionals);
                    db.DeathStatusAdditionalData.AddRange(deathStatusAdditionals);
                    context.SaveChanges();
                }

            }
        }

        private static void HandleNullableFields(DeathStatusAdditionalData deathModel, string birthYear, string birthMonth, string birthDay, string deathYear, string deathMonth, string deathDay, BirthStatusAdditionalData birthModel)
        {
            if (!string.IsNullOrEmpty(birthDay))
            {
                birthModel.Day = int.Parse(birthDay);
            }
            if (!string.IsNullOrEmpty(birthMonth))
            {
                birthModel.Month = int.Parse(birthMonth);
            }
            if (!string.IsNullOrEmpty(birthYear))
            {
                birthModel.Year = int.Parse(birthYear);
            }
            if (!string.IsNullOrEmpty(deathDay))
            {
                deathModel.Day = int.Parse(deathDay);
            }
            if (!string.IsNullOrEmpty(deathMonth))
            {
                deathModel.Month = int.Parse(deathMonth);
            }
            if (!string.IsNullOrEmpty(deathYear))
            {
                deathModel.Year = int.Parse(deathYear);
            }
        }
    }
}

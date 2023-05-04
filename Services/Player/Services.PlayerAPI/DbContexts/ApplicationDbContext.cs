using Services.PlayerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Services.PlayerAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<BirthStatusAdditionalData> BirthStatusAdditionalData { get; set; }
        public DbSet<DeathStatusAdditionalData> DeathStatusAdditionalData { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(b => b.Debut).IsRequired(false)
                ;

            modelBuilder.Entity<Player>().HasOne(b => b.BirthStatusAdditionalData).WithOne().HasForeignKey<BirthStatusAdditionalData>(l => l.PlayerId);

            modelBuilder.Entity<Player>().HasOne(b => b.DeathStatusAdditionalData).WithOne().HasForeignKey<DeathStatusAdditionalData>(l => l.PlayerId);
            modelBuilder.Entity<BirthStatusAdditionalData>().HasData(new BirthStatusAdditionalData() { PlayerId = "aa", City = "a", Country = "b", Day = 1, Month = 2, Year = 2000, State = "1", Id = Guid.NewGuid(), status = Models.Enums.LifeStatus.Birth });
            modelBuilder.Entity<DeathStatusAdditionalData>().HasData(new DeathStatusAdditionalData() { PlayerId = "aa", City = "a", Country = "b", Day = 1, Month = 2, Year = 2000, State = "1", Id = Guid.NewGuid(), status = Models.Enums.LifeStatus.Birth });

            modelBuilder.Entity<Player>().HasData(new Player()
            {
                Bats = "R",
                DdRefId = "123",
                Debut = new DateTime(),
                FinalGame = new DateTime(),
                NameFirst = "aa",
                NameGiven = "aa",
                NameLast = "aa",
                PlayerId = "aa",
                RetroId = "123",
                Throws = 1,
                Weight = 130
            });

            base.OnModelCreating(modelBuilder);

        }
    }
}

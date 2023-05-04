﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Services.PlayerAPI.DbContexts;

#nullable disable

namespace Services.PlayerAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Services.PlayerAPI.Models.BirthStatusAdditionalData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<string>("PlayerId")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("BirthStatusAdditionalData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbf77428-bf59-48e8-8120-6a89ad4c4c58"),
                            City = "a",
                            Country = "b",
                            Day = 1,
                            Month = 2,
                            PlayerId = "aa",
                            State = "1",
                            Year = 2000,
                            status = 0
                        });
                });

            modelBuilder.Entity("Services.PlayerAPI.Models.DeathStatusAdditionalData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<string>("PlayerId")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("DeathStatusAdditionalData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a00cee4d-ca89-4463-8d3f-e21fdbbdfeb3"),
                            City = "a",
                            Country = "b",
                            Day = 1,
                            Month = 2,
                            PlayerId = "aa",
                            State = "1",
                            Year = 2000,
                            status = 0
                        });
                });

            modelBuilder.Entity("Services.PlayerAPI.Models.Player", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("text");

                    b.Property<string>("Bats")
                        .HasColumnType("text");

                    b.Property<string>("DdRefId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Debut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("FinalGame")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("NameFirst")
                        .HasColumnType("text");

                    b.Property<string>("NameGiven")
                        .HasColumnType("text");

                    b.Property<string>("NameLast")
                        .HasColumnType("text");

                    b.Property<string>("RetroId")
                        .HasColumnType("text");

                    b.Property<int?>("Throws")
                        .HasColumnType("integer");

                    b.Property<int?>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("PlayerId");

                    b.ToTable("player");

                    b.HasData(
                        new
                        {
                            PlayerId = "aa",
                            Bats = "R",
                            DdRefId = "123",
                            Debut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FinalGame = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameFirst = "aa",
                            NameGiven = "aa",
                            NameLast = "aa",
                            RetroId = "123",
                            Throws = 1,
                            Weight = 130
                        });
                });

            modelBuilder.Entity("Services.PlayerAPI.Models.BirthStatusAdditionalData", b =>
                {
                    b.HasOne("Services.PlayerAPI.Models.Player", null)
                        .WithOne("BirthStatusAdditionalData")
                        .HasForeignKey("Services.PlayerAPI.Models.BirthStatusAdditionalData", "PlayerId");
                });

            modelBuilder.Entity("Services.PlayerAPI.Models.DeathStatusAdditionalData", b =>
                {
                    b.HasOne("Services.PlayerAPI.Models.Player", null)
                        .WithOne("DeathStatusAdditionalData")
                        .HasForeignKey("Services.PlayerAPI.Models.DeathStatusAdditionalData", "PlayerId");
                });

            modelBuilder.Entity("Services.PlayerAPI.Models.Player", b =>
                {
                    b.Navigation("BirthStatusAdditionalData");

                    b.Navigation("DeathStatusAdditionalData");
                });
#pragma warning restore 612, 618
        }
    }
}

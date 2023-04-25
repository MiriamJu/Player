﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Services.ProductAPI.DbContexts;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230425135411_UpdateDatabase")]
    partial class UpdateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Services.ProductAPI.Models.LifeStatusAdditionalData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BirthCity")
                        .HasColumnType("text");

                    b.Property<string>("BirthCountry")
                        .HasColumnType("text");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<string>("BirthState")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LifeStatusAdditionalData");
                });

            modelBuilder.Entity("Services.ProductAPI.Models.Player", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("text");

                    b.Property<int>("Bats")
                        .HasColumnType("integer");

                    b.Property<Guid?>("BirthStatusAdditionalDataId")
                        .HasColumnType("uuid");

                    b.Property<string>("DdRefId")
                        .HasColumnType("text");

                    b.Property<Guid?>("DeathStatusAdditionalDataId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Debut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FinalGame")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NameFirst")
                        .HasColumnType("text");

                    b.Property<string>("NameGiven")
                        .HasColumnType("text");

                    b.Property<string>("NameLast")
                        .HasColumnType("text");

                    b.Property<string>("RetroId")
                        .HasColumnType("text");

                    b.Property<int>("Throws")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("PlayerId");

                    b.HasIndex("BirthStatusAdditionalDataId");

                    b.HasIndex("DeathStatusAdditionalDataId");

                    b.ToTable("player");
                });

            modelBuilder.Entity("Services.ProductAPI.Models.Player", b =>
                {
                    b.HasOne("Services.ProductAPI.Models.LifeStatusAdditionalData", "BirthStatusAdditionalData")
                        .WithMany()
                        .HasForeignKey("BirthStatusAdditionalDataId");

                    b.HasOne("Services.ProductAPI.Models.LifeStatusAdditionalData", "DeathStatusAdditionalData")
                        .WithMany()
                        .HasForeignKey("DeathStatusAdditionalDataId");

                    b.Navigation("BirthStatusAdditionalData");

                    b.Navigation("DeathStatusAdditionalData");
                });
#pragma warning restore 612, 618
        }
    }
}

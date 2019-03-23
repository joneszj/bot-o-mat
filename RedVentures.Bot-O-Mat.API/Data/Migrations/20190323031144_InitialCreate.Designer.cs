﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedVentures.Bot_O_Mat.API.Data;

namespace RedVentures.Bot_O_Mat.API.Data.Migrations
{
    [DbContext(typeof(BotOMatContext))]
    [Migration("20190323031144_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Errand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActorId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("TimeToComplete");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Errands");
                });

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Robot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Robots");
                });

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Errand", b =>
                {
                    b.HasOne("RedVentures.Bot_O_Mat.API.Data.DbSets.Robot", "Actor")
                        .WithMany("Errands")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

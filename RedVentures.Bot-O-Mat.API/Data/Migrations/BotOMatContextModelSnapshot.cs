﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Data.Migrations
{
    [DbContext(typeof(BotOMatContext))]
    partial class BotOMatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.ErrandActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActorType");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ErrandActor");

                    b.HasDiscriminator<int>("ActorType");
                });

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Cyborg", b =>
                {
                    b.HasBaseType("RedVentures.Bot_O_Mat.API.Data.DbSets.ErrandActor");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Robot", b =>
                {
                    b.HasBaseType("RedVentures.Bot_O_Mat.API.Data.DbSets.ErrandActor");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("RedVentures.Bot_O_Mat.API.Data.DbSets.Errand", b =>
                {
                    b.HasOne("RedVentures.Bot_O_Mat.API.Data.DbSets.ErrandActor", "Actor")
                        .WithMany("Errands")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

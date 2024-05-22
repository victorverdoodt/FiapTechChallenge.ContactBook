﻿// <auto-generated />
using System;
using FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240522190317_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("DDDId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DDDId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.DDD", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<long>("RegionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("DDDs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "68",
                            RegionId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Code = "82",
                            RegionId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            Code = "92",
                            RegionId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            Code = "97",
                            RegionId = 3L
                        },
                        new
                        {
                            Id = 5L,
                            Code = "96",
                            RegionId = 4L
                        },
                        new
                        {
                            Id = 6L,
                            Code = "71",
                            RegionId = 5L
                        },
                        new
                        {
                            Id = 7L,
                            Code = "73",
                            RegionId = 5L
                        },
                        new
                        {
                            Id = 8L,
                            Code = "74",
                            RegionId = 5L
                        },
                        new
                        {
                            Id = 9L,
                            Code = "75",
                            RegionId = 5L
                        },
                        new
                        {
                            Id = 10L,
                            Code = "77",
                            RegionId = 5L
                        },
                        new
                        {
                            Id = 11L,
                            Code = "85",
                            RegionId = 6L
                        },
                        new
                        {
                            Id = 12L,
                            Code = "88",
                            RegionId = 6L
                        },
                        new
                        {
                            Id = 13L,
                            Code = "61",
                            RegionId = 7L
                        },
                        new
                        {
                            Id = 14L,
                            Code = "27",
                            RegionId = 8L
                        },
                        new
                        {
                            Id = 15L,
                            Code = "28",
                            RegionId = 8L
                        },
                        new
                        {
                            Id = 16L,
                            Code = "62",
                            RegionId = 9L
                        },
                        new
                        {
                            Id = 17L,
                            Code = "64",
                            RegionId = 9L
                        },
                        new
                        {
                            Id = 18L,
                            Code = "98",
                            RegionId = 10L
                        },
                        new
                        {
                            Id = 19L,
                            Code = "99",
                            RegionId = 10L
                        },
                        new
                        {
                            Id = 20L,
                            Code = "31",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 21L,
                            Code = "32",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 22L,
                            Code = "33",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 23L,
                            Code = "34",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 24L,
                            Code = "35",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 25L,
                            Code = "37",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 26L,
                            Code = "38",
                            RegionId = 11L
                        },
                        new
                        {
                            Id = 27L,
                            Code = "67",
                            RegionId = 12L
                        },
                        new
                        {
                            Id = 28L,
                            Code = "65",
                            RegionId = 13L
                        },
                        new
                        {
                            Id = 29L,
                            Code = "66",
                            RegionId = 13L
                        },
                        new
                        {
                            Id = 30L,
                            Code = "91",
                            RegionId = 14L
                        },
                        new
                        {
                            Id = 31L,
                            Code = "93",
                            RegionId = 14L
                        },
                        new
                        {
                            Id = 32L,
                            Code = "94",
                            RegionId = 14L
                        },
                        new
                        {
                            Id = 33L,
                            Code = "83",
                            RegionId = 15L
                        },
                        new
                        {
                            Id = 34L,
                            Code = "81",
                            RegionId = 16L
                        },
                        new
                        {
                            Id = 35L,
                            Code = "87",
                            RegionId = 16L
                        },
                        new
                        {
                            Id = 36L,
                            Code = "86",
                            RegionId = 17L
                        },
                        new
                        {
                            Id = 37L,
                            Code = "89",
                            RegionId = 17L
                        },
                        new
                        {
                            Id = 38L,
                            Code = "41",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 39L,
                            Code = "42",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 40L,
                            Code = "43",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 41L,
                            Code = "44",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 42L,
                            Code = "45",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 43L,
                            Code = "46",
                            RegionId = 18L
                        },
                        new
                        {
                            Id = 44L,
                            Code = "21",
                            RegionId = 19L
                        },
                        new
                        {
                            Id = 45L,
                            Code = "22",
                            RegionId = 19L
                        },
                        new
                        {
                            Id = 46L,
                            Code = "24",
                            RegionId = 19L
                        },
                        new
                        {
                            Id = 47L,
                            Code = "84",
                            RegionId = 20L
                        },
                        new
                        {
                            Id = 48L,
                            Code = "69",
                            RegionId = 21L
                        },
                        new
                        {
                            Id = 49L,
                            Code = "95",
                            RegionId = 22L
                        },
                        new
                        {
                            Id = 50L,
                            Code = "51",
                            RegionId = 23L
                        },
                        new
                        {
                            Id = 51L,
                            Code = "53",
                            RegionId = 23L
                        },
                        new
                        {
                            Id = 52L,
                            Code = "54",
                            RegionId = 23L
                        },
                        new
                        {
                            Id = 53L,
                            Code = "55",
                            RegionId = 23L
                        },
                        new
                        {
                            Id = 54L,
                            Code = "47",
                            RegionId = 24L
                        },
                        new
                        {
                            Id = 55L,
                            Code = "48",
                            RegionId = 24L
                        },
                        new
                        {
                            Id = 56L,
                            Code = "49",
                            RegionId = 24L
                        },
                        new
                        {
                            Id = 57L,
                            Code = "79",
                            RegionId = 25L
                        },
                        new
                        {
                            Id = 58L,
                            Code = "11",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 59L,
                            Code = "12",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 60L,
                            Code = "13",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 61L,
                            Code = "14",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 62L,
                            Code = "15",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 63L,
                            Code = "16",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 64L,
                            Code = "17",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 65L,
                            Code = "18",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 66L,
                            Code = "19",
                            RegionId = 26L
                        },
                        new
                        {
                            Id = 67L,
                            Code = "63",
                            RegionId = 27L
                        });
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Region", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "AC"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "AL"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "AM"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "AP"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "BA"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "CE"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "DF"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "ES"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "GO"
                        },
                        new
                        {
                            Id = 10L,
                            Name = "MA"
                        },
                        new
                        {
                            Id = 11L,
                            Name = "MG"
                        },
                        new
                        {
                            Id = 12L,
                            Name = "MS"
                        },
                        new
                        {
                            Id = 13L,
                            Name = "MT"
                        },
                        new
                        {
                            Id = 14L,
                            Name = "PA"
                        },
                        new
                        {
                            Id = 15L,
                            Name = "PB"
                        },
                        new
                        {
                            Id = 16L,
                            Name = "PE"
                        },
                        new
                        {
                            Id = 17L,
                            Name = "PI"
                        },
                        new
                        {
                            Id = 18L,
                            Name = "PR"
                        },
                        new
                        {
                            Id = 19L,
                            Name = "RJ"
                        },
                        new
                        {
                            Id = 20L,
                            Name = "RN"
                        },
                        new
                        {
                            Id = 21L,
                            Name = "RO"
                        },
                        new
                        {
                            Id = 22L,
                            Name = "RR"
                        },
                        new
                        {
                            Id = 23L,
                            Name = "RS"
                        },
                        new
                        {
                            Id = 24L,
                            Name = "SC"
                        },
                        new
                        {
                            Id = 25L,
                            Name = "SE"
                        },
                        new
                        {
                            Id = 26L,
                            Name = "SP"
                        },
                        new
                        {
                            Id = 27L,
                            Name = "TO"
                        });
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Contact", b =>
                {
                    b.HasOne("FiapTechChallenge.ContactBook.Domain.Core.Entities.DDD", "DDDNavigation")
                        .WithMany("Contacts")
                        .HasForeignKey("DDDId");

                    b.Navigation("DDDNavigation");
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.DDD", b =>
                {
                    b.HasOne("FiapTechChallenge.ContactBook.Domain.Core.Entities.Region", "RegionNavigation")
                        .WithMany("DDDs")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegionNavigation");
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.DDD", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Region", b =>
                {
                    b.Navigation("DDDs");
                });
#pragma warning restore 612, 618
        }
    }
}

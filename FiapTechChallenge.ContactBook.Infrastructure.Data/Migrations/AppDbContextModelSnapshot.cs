﻿// <auto-generated />
using System;
using FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Contact", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<int?>("DDDId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DDDId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DDDId = 13,
                            Email = "lucas.silva@example.com",
                            Name = "Lucas Silva",
                            Phone = "66912345678"
                        },
                        new
                        {
                            Id = 2,
                            DDDId = 16,
                            Email = "mateus.santos@example.com",
                            Name = "Mateus Santos",
                            Phone = "81956781234"
                        },
                        new
                        {
                            Id = 3,
                            DDDId = 22,
                            Email = "gabriel.oliveira@example.com",
                            Name = "Gabriel Oliveira",
                            Phone = "95934567890"
                        },
                        new
                        {
                            Id = 4,
                            DDDId = 10,
                            Email = "ana.souza@example.com",
                            Name = "Ana Souza",
                            Phone = "99345678901"
                        },
                        new
                        {
                            Id = 5,
                            DDDId = 14,
                            Email = "julia.rodrigues@example.com",
                            Name = "Julia Rodrigues",
                            Phone = "93345678901"
                        },
                        new
                        {
                            Id = 6,
                            DDDId = 5,
                            Email = "mariana.almeida@example.com",
                            Name = "Mariana Almeida",
                            Phone = "71345678901"
                        },
                        new
                        {
                            Id = 7,
                            DDDId = 5,
                            Email = "rafael.costa@example.com",
                            Name = "Rafael Costa",
                            Phone = "71345678901"
                        },
                        new
                        {
                            Id = 8,
                            DDDId = 5,
                            Email = "fernanda.gomes@example.com",
                            Name = "Fernanda Gomes",
                            Phone = "71345678901"
                        },
                        new
                        {
                            Id = 9,
                            DDDId = 5,
                            Email = "carlos.martins@example.com",
                            Name = "Carlos Martins",
                            Phone = "71345678901"
                        },
                        new
                        {
                            Id = 10,
                            DDDId = 5,
                            Email = "laura.lima@example.com",
                            Name = "Laura Lima",
                            Phone = "71345678901"
                        },
                        new
                        {
                            Id = 11,
                            DDDId = 20,
                            Email = "lucas.santos@example.com",
                            Name = "Lucas Santos",
                            Phone = "84345678901"
                        },
                        new
                        {
                            Id = 12,
                            DDDId = 20,
                            Email = "mateus.oliveira@example.com",
                            Name = "Mateus Oliveira",
                            Phone = "84345678901"
                        },
                        new
                        {
                            Id = 13,
                            DDDId = 62,
                            Email = "gabriel.silva@example.com",
                            Name = "Gabriel Silva",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 14,
                            DDDId = 62,
                            Email = "ana.almeida@example.com",
                            Name = "Ana Almeida",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 15,
                            DDDId = 62,
                            Email = "julia.costa@example.com",
                            Name = "Julia Costa",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 16,
                            DDDId = 62,
                            Email = "mariana.rodrigues@example.com",
                            Name = "Mariana Rodrigues",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 17,
                            DDDId = 62,
                            Email = "rafael.gomes@example.com",
                            Name = "Rafael Gomes",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 18,
                            DDDId = 62,
                            Email = "fernanda.martins@example.com",
                            Name = "Fernanda Martins",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 19,
                            DDDId = 62,
                            Email = "carlos.lima@example.com",
                            Name = "Carlos Lima",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 20,
                            DDDId = 62,
                            Email = "laura.silva@example.com",
                            Name = "Laura Silva",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 21,
                            DDDId = 62,
                            Email = "lucas.costa@example.com",
                            Name = "Lucas Costa",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 22,
                            DDDId = 62,
                            Email = "mateus.martins@example.com",
                            Name = "Mateus Martins",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 23,
                            DDDId = 62,
                            Email = "gabriel.lima@example.com",
                            Name = "Gabriel Lima",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 24,
                            DDDId = 62,
                            Email = "ana.gomes@example.com",
                            Name = "Ana Gomes",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 25,
                            DDDId = 62,
                            Email = "julia.almeida@example.com",
                            Name = "Julia Almeida",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 26,
                            DDDId = 62,
                            Email = "mariana.silva@example.com",
                            Name = "Mariana Silva",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 27,
                            DDDId = 62,
                            Email = "rafael.santos@example.com",
                            Name = "Rafael Santos",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 28,
                            DDDId = 62,
                            Email = "fernanda.oliveira@example.com",
                            Name = "Fernanda Oliveira",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 29,
                            DDDId = 62,
                            Email = "carlos.silva@example.com",
                            Name = "Carlos Silva",
                            Phone = "15345678901"
                        },
                        new
                        {
                            Id = 30,
                            DDDId = 62,
                            Email = "laura.santos@example.com",
                            Name = "Laura Santos",
                            Phone = "15345678901"
                        });
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.DDD", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("DDDs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "68",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "82",
                            RegionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Code = "92",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 4,
                            Code = "97",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 5,
                            Code = "96",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 6,
                            Code = "71",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 7,
                            Code = "73",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 8,
                            Code = "74",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 9,
                            Code = "75",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 10,
                            Code = "77",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 11,
                            Code = "85",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 12,
                            Code = "88",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 13,
                            Code = "61",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 14,
                            Code = "27",
                            RegionId = 8
                        },
                        new
                        {
                            Id = 15,
                            Code = "28",
                            RegionId = 8
                        },
                        new
                        {
                            Id = 16,
                            Code = "62",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 17,
                            Code = "64",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 18,
                            Code = "98",
                            RegionId = 10
                        },
                        new
                        {
                            Id = 19,
                            Code = "99",
                            RegionId = 10
                        },
                        new
                        {
                            Id = 20,
                            Code = "31",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 21,
                            Code = "32",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 22,
                            Code = "33",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 23,
                            Code = "34",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 24,
                            Code = "35",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 25,
                            Code = "37",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 26,
                            Code = "38",
                            RegionId = 11
                        },
                        new
                        {
                            Id = 27,
                            Code = "67",
                            RegionId = 12
                        },
                        new
                        {
                            Id = 28,
                            Code = "65",
                            RegionId = 13
                        },
                        new
                        {
                            Id = 29,
                            Code = "66",
                            RegionId = 13
                        },
                        new
                        {
                            Id = 30,
                            Code = "91",
                            RegionId = 14
                        },
                        new
                        {
                            Id = 31,
                            Code = "93",
                            RegionId = 14
                        },
                        new
                        {
                            Id = 32,
                            Code = "94",
                            RegionId = 14
                        },
                        new
                        {
                            Id = 33,
                            Code = "83",
                            RegionId = 15
                        },
                        new
                        {
                            Id = 34,
                            Code = "81",
                            RegionId = 16
                        },
                        new
                        {
                            Id = 35,
                            Code = "87",
                            RegionId = 16
                        },
                        new
                        {
                            Id = 36,
                            Code = "86",
                            RegionId = 17
                        },
                        new
                        {
                            Id = 37,
                            Code = "89",
                            RegionId = 17
                        },
                        new
                        {
                            Id = 38,
                            Code = "41",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 39,
                            Code = "42",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 40,
                            Code = "43",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 41,
                            Code = "44",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 42,
                            Code = "45",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 43,
                            Code = "46",
                            RegionId = 18
                        },
                        new
                        {
                            Id = 44,
                            Code = "21",
                            RegionId = 19
                        },
                        new
                        {
                            Id = 45,
                            Code = "22",
                            RegionId = 19
                        },
                        new
                        {
                            Id = 46,
                            Code = "24",
                            RegionId = 19
                        },
                        new
                        {
                            Id = 47,
                            Code = "84",
                            RegionId = 20
                        },
                        new
                        {
                            Id = 48,
                            Code = "69",
                            RegionId = 21
                        },
                        new
                        {
                            Id = 49,
                            Code = "95",
                            RegionId = 22
                        },
                        new
                        {
                            Id = 50,
                            Code = "51",
                            RegionId = 23
                        },
                        new
                        {
                            Id = 51,
                            Code = "53",
                            RegionId = 23
                        },
                        new
                        {
                            Id = 52,
                            Code = "54",
                            RegionId = 23
                        },
                        new
                        {
                            Id = 53,
                            Code = "55",
                            RegionId = 23
                        },
                        new
                        {
                            Id = 54,
                            Code = "47",
                            RegionId = 24
                        },
                        new
                        {
                            Id = 55,
                            Code = "48",
                            RegionId = 24
                        },
                        new
                        {
                            Id = 56,
                            Code = "49",
                            RegionId = 24
                        },
                        new
                        {
                            Id = 57,
                            Code = "79",
                            RegionId = 25
                        },
                        new
                        {
                            Id = 58,
                            Code = "11",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 59,
                            Code = "12",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 60,
                            Code = "13",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 61,
                            Code = "14",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 62,
                            Code = "15",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 63,
                            Code = "16",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 64,
                            Code = "17",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 65,
                            Code = "18",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 66,
                            Code = "19",
                            RegionId = 26
                        },
                        new
                        {
                            Id = 67,
                            Code = "63",
                            RegionId = 27
                        });
                });

            modelBuilder.Entity("FiapTechChallenge.ContactBook.Domain.Core.Entities.Region", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "AL"
                        },
                        new
                        {
                            Id = 3,
                            Name = "AM"
                        },
                        new
                        {
                            Id = 4,
                            Name = "AP"
                        },
                        new
                        {
                            Id = 5,
                            Name = "BA"
                        },
                        new
                        {
                            Id = 6,
                            Name = "CE"
                        },
                        new
                        {
                            Id = 7,
                            Name = "DF"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ES"
                        },
                        new
                        {
                            Id = 9,
                            Name = "GO"
                        },
                        new
                        {
                            Id = 10,
                            Name = "MA"
                        },
                        new
                        {
                            Id = 11,
                            Name = "MG"
                        },
                        new
                        {
                            Id = 12,
                            Name = "MS"
                        },
                        new
                        {
                            Id = 13,
                            Name = "MT"
                        },
                        new
                        {
                            Id = 14,
                            Name = "PA"
                        },
                        new
                        {
                            Id = 15,
                            Name = "PB"
                        },
                        new
                        {
                            Id = 16,
                            Name = "PE"
                        },
                        new
                        {
                            Id = 17,
                            Name = "PI"
                        },
                        new
                        {
                            Id = 18,
                            Name = "PR"
                        },
                        new
                        {
                            Id = 19,
                            Name = "RJ"
                        },
                        new
                        {
                            Id = 20,
                            Name = "RN"
                        },
                        new
                        {
                            Id = 21,
                            Name = "RO"
                        },
                        new
                        {
                            Id = 22,
                            Name = "RR"
                        },
                        new
                        {
                            Id = 23,
                            Name = "RS"
                        },
                        new
                        {
                            Id = 24,
                            Name = "SC"
                        },
                        new
                        {
                            Id = 25,
                            Name = "SE"
                        },
                        new
                        {
                            Id = 26,
                            Name = "SP"
                        },
                        new
                        {
                            Id = 27,
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

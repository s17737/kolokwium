﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolokwium.Models;

namespace kolokwium.Migrations
{
    [DbContext(typeof(ArtiscDbContext))]
    [Migration("20200620134626_addedtablesnew")]
    partial class addedtablesnew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kolokwium.Models.Artist", b =>
                {
                    b.Property<int>("IdArtist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdArtist");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("kolokwium.Models.Artist_Event", b =>
                {
                    b.Property<int>("IdArtist")
                        .HasColumnType("int");

                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int?>("ArtistIdArtist")
                        .HasColumnType("int");

                    b.Property<int?>("EventIdEvent")
                        .HasColumnType("int");

                    b.Property<DateTime>("PerformanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdArtist", "IdEvent");

                    b.HasIndex("ArtistIdArtist");

                    b.HasIndex("EventIdEvent");

                    b.ToTable("Artist_Events");
                });

            modelBuilder.Entity("kolokwium.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("kolokwium.Models.Event_Organizer", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.Property<int?>("EventIdEvent")
                        .HasColumnType("int");

                    b.Property<int?>("OrganiserIdOrganiser")
                        .HasColumnType("int");

                    b.HasKey("IdEvent", "IdOrganiser");

                    b.HasIndex("EventIdEvent");

                    b.HasIndex("OrganiserIdOrganiser");

                    b.ToTable("Event_Organizers");
                });

            modelBuilder.Entity("kolokwium.Models.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdOrganiser");

                    b.ToTable("Organiser");
                });

            modelBuilder.Entity("kolokwium.Models.Artist_Event", b =>
                {
                    b.HasOne("kolokwium.Models.Artist", "Artist")
                        .WithMany("Artist_Events")
                        .HasForeignKey("ArtistIdArtist");

                    b.HasOne("kolokwium.Models.Event", "Event")
                        .WithMany("Artist_Events")
                        .HasForeignKey("EventIdEvent");
                });

            modelBuilder.Entity("kolokwium.Models.Event_Organizer", b =>
                {
                    b.HasOne("kolokwium.Models.Event", "Event")
                        .WithMany("Event_Organizer")
                        .HasForeignKey("EventIdEvent");

                    b.HasOne("kolokwium.Models.Organiser", "Organiser")
                        .WithMany()
                        .HasForeignKey("OrganiserIdOrganiser");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using LexiconMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMovie.Migrations
{
    [DbContext(typeof(LexiconMovieContext))]
    [Migration("20190516115356_AddMovies")]
    partial class AddMovies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Genre");

                    b.Property<float>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = 3,
                            Rating = 5f,
                            ReleaseDate = new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Titanic"
                        },
                        new
                        {
                            Id = 2,
                            Genre = 0,
                            Rating = 2.3f,
                            ReleaseDate = new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Screem"
                        },
                        new
                        {
                            Id = 3,
                            Genre = 0,
                            Rating = 4.4f,
                            ReleaseDate = new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

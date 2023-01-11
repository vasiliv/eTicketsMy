﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTicketsMy.Data;

namespace eTicketsMy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eTicketsMy.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the third actor",
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the fourth actor",
                            FullName = "Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the fifth actor",
                            FullName = "Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });
                });

            modelBuilder.Entity("eTicketsMy.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 6
                        });
                });

            modelBuilder.Entity("eTicketsMy.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Name = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the description of the second cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Name = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the description of the third cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Name = "Cinema 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the description of the fourth cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Name = "Cinema 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the description of the fifth cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Name = "Cinema 5"
                        });
                });

            modelBuilder.Entity("eTicketsMy.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 3,
                            Description = "This is the Life movie description",
                            EndDate = new DateTime(2023, 1, 21, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(6447),
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieCategory = 4,
                            Name = "Life",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2023, 1, 1, 19, 9, 48, 375, DateTimeKind.Local).AddTicks(3410)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Description = "This is the Shawshank Redemption description",
                            EndDate = new DateTime(2023, 1, 14, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7843),
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieCategory = 1,
                            Name = "The Shawshank Redemption",
                            Price = 29.5,
                            ProducerId = 1,
                            StartDate = new DateTime(2023, 1, 11, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7837)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 1,
                            Description = "This is the Race movie description",
                            EndDate = new DateTime(2023, 1, 6, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7873),
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieCategory = 4,
                            Name = "Race",
                            Price = 39.5,
                            ProducerId = 2,
                            StartDate = new DateTime(2023, 1, 1, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7871)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 4,
                            Description = "This is the Ghost movie description",
                            EndDate = new DateTime(2023, 1, 18, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7900),
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieCategory = 6,
                            Name = "Ghost",
                            Price = 39.5,
                            ProducerId = 4,
                            StartDate = new DateTime(2023, 1, 11, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7899)
                        },
                        new
                        {
                            Id = 5,
                            CinemaId = 1,
                            Description = "This is the Scoob movie description",
                            EndDate = new DateTime(2023, 1, 9, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7925),
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieCategory = 5,
                            Name = "Scoob",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2023, 1, 1, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7923)
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 1,
                            Description = "This is the Cold Soles movie description",
                            EndDate = new DateTime(2023, 1, 31, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7953),
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieCategory = 3,
                            Name = "Cold Soles",
                            Price = 39.5,
                            ProducerId = 5,
                            StartDate = new DateTime(2023, 1, 14, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7951)
                        });
                });

            modelBuilder.Entity("eTicketsMy.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first producer",
                            FullName = "Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second producer",
                            FullName = "Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the third producer",
                            FullName = "Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the fourth producer",
                            FullName = "Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the fifth producer",
                            FullName = "Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        });
                });

            modelBuilder.Entity("eTicketsMy.Models.Actor_Movie", b =>
                {
                    b.HasOne("eTicketsMy.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketsMy.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("eTicketsMy.Models.Movie", b =>
                {
                    b.HasOne("eTicketsMy.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketsMy.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("eTicketsMy.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("eTicketsMy.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("eTicketsMy.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("eTicketsMy.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}

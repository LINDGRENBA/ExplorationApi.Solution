﻿// <auto-generated />
using ExplorationApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExplorationApi.Solution.Migrations
{
    [DbContext(typeof(ExplorationApiContext))]
    partial class ExplorationApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExplorationApi.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.Property<string>("UserName");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            PlaceId = 1,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 2,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 3,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 4,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 5,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 6,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 7,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 8,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 9,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 10,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 11,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 12,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 13,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 14,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 15,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 16,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 17,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 18,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 19,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 20,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 21,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 22,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 23,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 24,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 25,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 26,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 27,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 28,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 29,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 30,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 31,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 32,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 33,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 34,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 35,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 36,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 37,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 38,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 39,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 40,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 41,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 42,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 43,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 44,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        },
                        new
                        {
                            PlaceId = 45,
                            Country = "Mexico",
                            Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.",
                            Name = "Puerta Vallarta",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 46,
                            Country = "USA",
                            Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.",
                            Name = "Yachats",
                            Rating = 4,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 47,
                            Country = "USA",
                            Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.",
                            Name = "Timothy Lake",
                            Rating = 2,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 48,
                            Country = "Mexico",
                            Description = "There was a hurricane! Was there for a wedding that had to be postponed.",
                            Name = "Puerta Vallarta",
                            Rating = 1,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 49,
                            Country = "France",
                            Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.",
                            Name = "La Palud sur Verdon",
                            Rating = 5,
                            UserName = "Kate"
                        },
                        new
                        {
                            PlaceId = 50,
                            Country = "Japan",
                            Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan",
                            Name = "Matsue",
                            Rating = 5,
                            UserName = "Brittany"
                        },
                        new
                        {
                            PlaceId = 51,
                            Country = "Idk hawaii?",
                            Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.",
                            Name = "Atlantis",
                            Rating = 1,
                            UserName = "Cody"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

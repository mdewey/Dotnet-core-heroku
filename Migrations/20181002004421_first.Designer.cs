﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using heroku_test;

namespace herokutest.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181002004421_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("heroku_test.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cool");

                    b.Property<string>("Something");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new { Id = 1, Cool = "Yes I am", Something = " not something" },
                        new { Id = 2, Cool = "Yes I am not", Something = "something" },
                        new { Id = 3, Cool = "No I am", Something = "i am the best something" },
                        new { Id = 4, Cool = "Nope, I am", Something = " meh?" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

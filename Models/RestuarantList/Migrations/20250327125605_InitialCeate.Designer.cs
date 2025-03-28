﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestuarantList.Data;

#nullable disable

namespace RestuarantList.Migrations
{
    [DbContext(typeof(RestuarantListContext))]
    [Migration("20250327125605_InitialCeate")]
    partial class InitialCeate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestuarantList.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pizza",
                            price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pasta",
                            price = 9.0
                        });
                });

            modelBuilder.Entity("RestuarantList.Models.Restuarant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restuarants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "10 Echola St, Motherwell, EC, 6211",
                            ImageURL = "https:www.whereyouat.com/r_gallery_images/rgallery-21635/Best_Italian_Pizza2.jpg",
                            Name = "Gourmet Pizzeria"
                        });
                });

            modelBuilder.Entity("RestuarantList.Models.RestuarantDish", b =>
                {
                    b.Property<int>("RestuarantId")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.HasKey("RestuarantId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("restuarantDishes");

                    b.HasData(
                        new
                        {
                            RestuarantId = 1,
                            DishId = 1
                        },
                        new
                        {
                            RestuarantId = 1,
                            DishId = 2
                        });
                });

            modelBuilder.Entity("RestuarantList.Models.RestuarantDish", b =>
                {
                    b.HasOne("RestuarantList.Models.Dish", "Dish")
                        .WithMany("RestuarantDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestuarantList.Models.Restuarant", "Restuarant")
                        .WithMany("RestuarantDishes")
                        .HasForeignKey("RestuarantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Restuarant");
                });

            modelBuilder.Entity("RestuarantList.Models.Dish", b =>
                {
                    b.Navigation("RestuarantDishes");
                });

            modelBuilder.Entity("RestuarantList.Models.Restuarant", b =>
                {
                    b.Navigation("RestuarantDishes");
                });
#pragma warning restore 612, 618
        }
    }
}

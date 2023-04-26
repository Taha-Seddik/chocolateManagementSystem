﻿// <auto-generated />
using ChocolateManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChocolateManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ChocolateSystemContext))]
    [Migration("20230426162905_first-migration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChocolateBarWholesaler", b =>
                {
                    b.Property<int>("ChocolateBarsId")
                        .HasColumnType("int");

                    b.Property<int>("WholesalersId")
                        .HasColumnType("int");

                    b.HasKey("ChocolateBarsId", "WholesalersId");

                    b.HasIndex("WholesalersId");

                    b.ToTable("ChocolateBarWholesaler");
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.ChocolateBar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cacao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("ChocolateBars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cacao = 12.5m,
                            FactoryId = 1,
                            Name = "White Chocolate",
                            Price = 9.5m
                        },
                        new
                        {
                            Id = 2,
                            Cacao = 20m,
                            FactoryId = 1,
                            Name = "Beast Chocolate",
                            Price = 22.99m
                        },
                        new
                        {
                            Id = 3,
                            Cacao = 5m,
                            FactoryId = 1,
                            Name = "Mix Chocolate",
                            Price = 5.5m
                        },
                        new
                        {
                            Id = 4,
                            Cacao = 10m,
                            FactoryId = 2,
                            Name = "Strawberry Chocolate",
                            Price = 12m
                        },
                        new
                        {
                            Id = 5,
                            Cacao = 11m,
                            FactoryId = 2,
                            Name = "Dark Chocolate",
                            Price = 9m
                        });
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.ChocolateFactory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChocolateFactories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Neuhaus"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ChocoPlus"
                        });
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.Wholesaler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wholesalers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mamadou"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Keita"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Heung"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Pedro"
                        });
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.WholesalerChocolateStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChocolateBarId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("WholesalerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WholesalersChocolateBarsStocks");
                });

            modelBuilder.Entity("ChocolateBarWholesaler", b =>
                {
                    b.HasOne("ChocolateManagementSystem.Domain.Entities.ChocolateBar", null)
                        .WithMany()
                        .HasForeignKey("ChocolateBarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChocolateManagementSystem.Domain.Entities.Wholesaler", null)
                        .WithMany()
                        .HasForeignKey("WholesalersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.ChocolateBar", b =>
                {
                    b.HasOne("ChocolateManagementSystem.Domain.Entities.ChocolateFactory", "Factory")
                        .WithMany("ChocolateBars")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("ChocolateManagementSystem.Domain.Entities.ChocolateFactory", b =>
                {
                    b.Navigation("ChocolateBars");
                });
#pragma warning restore 612, 618
        }
    }
}

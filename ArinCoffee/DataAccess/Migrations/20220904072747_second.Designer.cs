﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ArinCoffeeContext))]
    [Migration("20220904072747_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ageofcats_ArinCoffee")
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Card", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Rewiew")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("Id");

                    b.ToTable("Comment", "dbo");
                });

            modelBuilder.Entity("Entities.Models.FeedBack", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeedBack", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int>("CardId")
                        .HasColumnType("int")
                        .HasColumnName("CardID");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("date");

                    b.Property<DateTime?>("OrderTime")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("OrderId");

                    b.HasIndex("CardId");

                    b.ToTable("Order", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Image2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Image3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Image4")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Image5")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("MiniDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiniImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Product", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Watch", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Watch", "dbo");
                });

            modelBuilder.Entity("Entities.Models.Card", b =>
                {
                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("Cards")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Card_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.HasOne("Entities.Models.Card", "Card")
                        .WithMany("Orders")
                        .HasForeignKey("CardId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Card");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Entities.Models.Watch", b =>
                {
                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("Watches")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Watch_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Models.Card", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Watches");
                });
#pragma warning restore 612, 618
        }
    }
}

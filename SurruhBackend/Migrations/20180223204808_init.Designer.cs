﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SurruhBackend.Models;
using System;

namespace SurruhBackend.Migrations
{
    [DbContext(typeof(SurruhBackendContext))]
    [Migration("20180223204808_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SurruhBackend.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType");

                    b.Property<byte[]>("Data");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<string>("Name");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SurruhBackend.Models.ImageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Extension");

                    b.Property<int>("ImageId");

                    b.Property<bool>("IsVisible");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ImageId")
                        .IsUnique();

                    b.ToTable("ImageData");
                });

            modelBuilder.Entity("SurruhBackend.Models.ImageData_Tag", b =>
                {
                    b.Property<int>("ImageDataId");

                    b.Property<int>("TagId");

                    b.HasKey("ImageDataId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ImageData_Tag");
                });

            modelBuilder.Entity("SurruhBackend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ProductDescription");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SurruhBackend.Models.ProductOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("SurruhBackend.Models.ProductOption_ImageData", b =>
                {
                    b.Property<int>("ProductOptionId");

                    b.Property<int>("ImageDataId");

                    b.HasKey("ProductOptionId", "ImageDataId");

                    b.HasIndex("ImageDataId");

                    b.ToTable("ProductOption_ImageData");
                });

            modelBuilder.Entity("SurruhBackend.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SurruhBackend.Models.ImageData", b =>
                {
                    b.HasOne("SurruhBackend.Models.Image", "Image")
                        .WithOne("ImageData")
                        .HasForeignKey("SurruhBackend.Models.ImageData", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SurruhBackend.Models.ImageData_Tag", b =>
                {
                    b.HasOne("SurruhBackend.Models.ImageData", "ImageData")
                        .WithMany("ImageData_Tags")
                        .HasForeignKey("ImageDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SurruhBackend.Models.Tag", "Tag")
                        .WithMany("ImageData_Tags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SurruhBackend.Models.ProductOption", b =>
                {
                    b.HasOne("SurruhBackend.Models.Product", "Product")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SurruhBackend.Models.ProductOption_ImageData", b =>
                {
                    b.HasOne("SurruhBackend.Models.ImageData", "ImageData")
                        .WithMany("ProductOption_ImageData")
                        .HasForeignKey("ImageDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SurruhBackend.Models.ProductOption", "ProductOption")
                        .WithMany("ProductOption_ImageData")
                        .HasForeignKey("ProductOptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
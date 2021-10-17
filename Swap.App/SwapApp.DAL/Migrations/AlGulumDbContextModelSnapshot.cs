﻿// <auto-generated />
using System;
using AlGulumVerGulum.DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlGulumVerGulum.DAL.Migrations
{
    [DbContext(typeof(AlGulumDbContext))]
    partial class AlGulumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PicturePath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 9, 20, 19, 51, 33, 29, DateTimeKind.Local).AddTicks(9058),
                            Description = "Tüm elektronik ürünler burada",
                            IsActive = true,
                            Name = "Elektronik",
                            Updated = new DateTime(2021, 9, 20, 19, 51, 33, 31, DateTimeKind.Local).AddTicks(3953)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 9, 20, 19, 51, 33, 31, DateTimeKind.Local).AddTicks(5988),
                            Description = "Tüm mobilya ürünleri burada",
                            IsActive = true,
                            Name = "Mobilya",
                            Updated = new DateTime(2021, 9, 20, 19, 51, 33, 31, DateTimeKind.Local).AddTicks(6001)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 9, 20, 19, 51, 33, 31, DateTimeKind.Local).AddTicks(6028),
                            Description = "Tüm giyim ürünleri",
                            IsActive = true,
                            Name = "Giyim",
                            Updated = new DateTime(2021, 9, 20, 19, 51, 33, 31, DateTimeKind.Local).AddTicks(6029)
                        });
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Envelope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("NoticeId")
                        .HasColumnType("int");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int?>("SwapId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NoticeId");

                    b.HasIndex("RequestId");

                    b.HasIndex("SwapId");

                    b.ToTable("Envelopes");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Notice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoticeId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("NoticeId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Swap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderComment")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<byte>("SenderPoint")
                        .HasColumnType("tinyint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TargetComment")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<byte>("TargetPoint")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Swaps");
                });

            modelBuilder.Entity("NoticeRequest", b =>
                {
                    b.Property<int>("NoticesId")
                        .HasColumnType("int");

                    b.Property<int>("RequestsId")
                        .HasColumnType("int");

                    b.HasKey("NoticesId", "RequestsId");

                    b.HasIndex("RequestsId");

                    b.ToTable("NoticeRequest");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Envelope", b =>
                {
                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Notice", "Notice")
                        .WithMany()
                        .HasForeignKey("NoticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Request", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Swap", "Swap")
                        .WithMany("Envelopes")
                        .HasForeignKey("SwapId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Notice");

                    b.Navigation("Request");

                    b.Navigation("Swap");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Notice", b =>
                {
                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Category", "Category")
                        .WithMany("Notices")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.AppUser", "Owner")
                        .WithMany("Notices")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Picture", b =>
                {
                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Notice", "Notice")
                        .WithMany("Pictures")
                        .HasForeignKey("NoticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notice");
                });

            modelBuilder.Entity("NoticeRequest", b =>
                {
                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Notice", null)
                        .WithMany()
                        .HasForeignKey("NoticesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlGulumVerGulum.DOMAIN.Entities.Request", null)
                        .WithMany()
                        .HasForeignKey("RequestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.AppUser", b =>
                {
                    b.Navigation("Notices");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Category", b =>
                {
                    b.Navigation("Notices");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Notice", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("AlGulumVerGulum.DOMAIN.Entities.Swap", b =>
                {
                    b.Navigation("Envelopes");
                });
#pragma warning restore 612, 618
        }
    }
}

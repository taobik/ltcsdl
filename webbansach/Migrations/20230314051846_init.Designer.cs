﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webbansach.Data;

#nullable disable

namespace webbansach.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230314051846_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webbansach.Models.NhaXuatBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NXB");
                });

            modelBuilder.Entity("webbansach.Models.Sach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<int>("GiaNhap")
                        .HasColumnType("int");

                    b.Property<int>("NhaXuatBanId")
                        .HasColumnType("int");

                    b.Property<int>("TacGiaId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheLoaiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NhaXuatBanId");

                    b.HasIndex("TacGiaId");

                    b.HasIndex("TheLoaiId");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("webbansach.Models.TacGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenTG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("webbansach.Models.TheLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("webbansach.Models.Sach", b =>
                {
                    b.HasOne("webbansach.Models.NhaXuatBan", "NhaXuatBan")
                        .WithMany("Sach")
                        .HasForeignKey("NhaXuatBanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webbansach.Models.TacGia", "TacGia")
                        .WithMany("Sach")
                        .HasForeignKey("TacGiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webbansach.Models.TheLoai", "TheLoai")
                        .WithMany("Sach")
                        .HasForeignKey("TheLoaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaXuatBan");

                    b.Navigation("TacGia");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("webbansach.Models.NhaXuatBan", b =>
                {
                    b.Navigation("Sach");
                });

            modelBuilder.Entity("webbansach.Models.TacGia", b =>
                {
                    b.Navigation("Sach");
                });

            modelBuilder.Entity("webbansach.Models.TheLoai", b =>
                {
                    b.Navigation("Sach");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BarberEaseApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarberEaseApi.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BarberEaseApi.Entities.AppointmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("client_id");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<Guid>("EstablishmentServiceId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("establishment_service_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EstablishmentServiceId");

                    b.ToTable("appointments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("aa4f97ba-514e-4964-a2f2-f639d2400aa6"),
                            ClientId = new Guid("ba997890-aa6a-4c10-bbad-c930a19b119f"),
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            Date = new DateTime(2024, 6, 6, 9, 0, 0, 0, DateTimeKind.Local),
                            EstablishmentServiceId = new Guid("18e9b482-7c3e-4db5-8c40-3d79c9ac4f66"),
                            Status = "CONFIRMED",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("9454ae1e-38a0-4a24-86e4-548e672c6396"),
                            ClientId = new Guid("ba997890-aa6a-4c10-bbad-c930a19b119f"),
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            Date = new DateTime(2024, 6, 6, 9, 30, 0, 0, DateTimeKind.Local),
                            EstablishmentServiceId = new Guid("21e79cb3-9385-4f9c-9e55-28c6c3b0a8bc"),
                            Status = "CANCELLED",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("7f16ad90-8d07-42ac-9257-dbb2a9aa7343"),
                            ClientId = new Guid("ba997890-aa6a-4c10-bbad-c930a19b119f"),
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            Date = new DateTime(2024, 6, 6, 10, 0, 0, 0, DateTimeKind.Local),
                            EstablishmentServiceId = new Guid("cffb2e84-71a1-4977-afb2-13197662210b"),
                            Status = "RECEIVED",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BarberEaseApi.Entities.ClientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("hashed_password");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("state");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("clients", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba997890-aa6a-4c10-bbad-c930a19b119f"),
                            City = "São Paulo",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            Email = "client@default.com",
                            FirstName = "Client",
                            HashedPassword = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                            LastName = "Default",
                            Phone = "119123456789",
                            State = "São Paulo",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cep");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cnpj");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("company_name");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("hashed_password");

                    b.Property<string>("OwnerFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("owner_first_name");

                    b.Property<string>("OwnerLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("owner_last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("state");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("establishments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            Address = "Rua Francisco Salzillo",
                            Cep = "03923087",
                            City = "São Paulo",
                            Cnpj = "72835673000172",
                            CompanyName = "Establishment Default",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            Email = "establishment@default.com",
                            HashedPassword = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                            OwnerFirstName = "Establishment",
                            OwnerLastName = "Default",
                            Phone = "119123456789",
                            State = "São Paulo",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentPeriodEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClosingTime")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("closing_time");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("day_of_week");

                    b.Property<Guid>("EstablishmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("establishment_id");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit")
                        .HasColumnName("is_closed");

                    b.Property<string>("OpeningTime")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("opening_time");

                    b.Property<string>("TimeBetweenService")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("time_between_service");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId");

                    b.ToTable("establishment_periods", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("182cde4a-b74d-49a9-a2ec-59d1a82c2e68"),
                            ClosingTime = "18:00",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "MONDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = false,
                            OpeningTime = "09:00",
                            TimeBetweenService = "00:30",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("58695664-a938-4dc7-9384-54616a77ad9f"),
                            ClosingTime = "18:00",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "TUESDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = false,
                            OpeningTime = "09:00",
                            TimeBetweenService = "00:30",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("cdb52f2e-04e2-466c-8154-1403eb4aed63"),
                            ClosingTime = "18:00",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "WEDNESDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = false,
                            OpeningTime = "09:00",
                            TimeBetweenService = "00:30",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("30813908-3985-42c2-8cee-0b7fde58a1be"),
                            ClosingTime = "18:00",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "THURSDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = false,
                            OpeningTime = "09:00",
                            TimeBetweenService = "00:30",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("ecf07789-b490-4c26-acc7-8acd123767b6"),
                            ClosingTime = "18:00",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "FRIDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = false,
                            OpeningTime = "09:00",
                            TimeBetweenService = "00:30",
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("c7e3ba97-ae61-4ee5-bfb2-5e571cf6856e"),
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "SATURDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = true,
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("4568c25f-ee4c-430f-a852-99d2d27bad8f"),
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            DayOfWeek = "SUNDAY",
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            IsClosed = true,
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentServiceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("category");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<Guid>("EstablishmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("establishment_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId");

                    b.ToTable("establishment_services", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("18e9b482-7c3e-4db5-8c40-3d79c9ac4f66"),
                            Category = "Corte de Cabelo",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            Name = "Corte de Cabelo Masculino",
                            Price = 50.0,
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("21e79cb3-9385-4f9c-9e55-28c6c3b0a8bc"),
                            Category = "Barba",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            Name = "Barba Completa",
                            Price = 35.0,
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = new Guid("cffb2e84-71a1-4977-afb2-13197662210b"),
                            Category = "Sobrancelha",
                            CreatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local),
                            EstablishmentId = new Guid("db279123-e792-44aa-9c43-87c869ff5abd"),
                            Name = "Design de Sobrancelhas",
                            Price = 25.0,
                            UpdatedAt = new DateTime(2024, 6, 5, 21, 41, 32, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BarberEaseApi.Entities.AppointmentEntity", b =>
                {
                    b.HasOne("BarberEaseApi.Entities.ClientEntity", "Client")
                        .WithMany("Appointments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberEaseApi.Entities.EstablishmentServiceEntity", "EstablishmentService")
                        .WithMany("Appointments")
                        .HasForeignKey("EstablishmentServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("EstablishmentService");
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentPeriodEntity", b =>
                {
                    b.HasOne("BarberEaseApi.Entities.EstablishmentEntity", "Establishment")
                        .WithMany("EstablishmentPeriods")
                        .HasForeignKey("EstablishmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentServiceEntity", b =>
                {
                    b.HasOne("BarberEaseApi.Entities.EstablishmentEntity", "Establishment")
                        .WithMany("EstablishmentServices")
                        .HasForeignKey("EstablishmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("BarberEaseApi.Entities.ClientEntity", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentEntity", b =>
                {
                    b.Navigation("EstablishmentPeriods");

                    b.Navigation("EstablishmentServices");
                });

            modelBuilder.Entity("BarberEaseApi.Entities.EstablishmentServiceEntity", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}

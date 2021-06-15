﻿// <auto-generated />
using System;
using IEP.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IEP.Api.Migrations
{
    [DbContext(typeof(IEPApiContext))]
    [Migration("20210614101212_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IEP.Api.Model.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InspectorId")
                        .HasColumnType("int");

                    b.Property<int>("InspectroId")
                        .HasColumnType("int");

                    b.Property<int>("LoactionId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InspectorId");

                    b.HasIndex("LocationId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Inspector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Inspector");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InspectionDateTime")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("InspectorId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InspectorId");

                    b.HasIndex("LocationId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTown")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Sample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InspectId")
                        .HasColumnType("int");

                    b.Property<int?>("InspectorId")
                        .HasColumnType("int");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Picked")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProduceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InspectorId");

                    b.HasIndex("JobId");

                    b.HasIndex("LocationId");

                    b.ToTable("Sample");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Client", b =>
                {
                    b.HasOne("IEP.Api.Model.Entities.Inspector", "Inspector")
                        .WithMany()
                        .HasForeignKey("InspectorId");

                    b.HasOne("IEP.Api.Model.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Inspector");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Inspector", b =>
                {
                    b.HasOne("IEP.Api.Model.Entities.Department", "Department")
                        .WithMany("Inspectors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Job", b =>
                {
                    b.HasOne("IEP.Api.Model.Entities.Client", null)
                        .WithMany("Jobs")
                        .HasForeignKey("ClientId");

                    b.HasOne("IEP.Api.Model.Entities.Department", "Department")
                        .WithMany("Jobs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IEP.Api.Model.Entities.Inspector", "Inspector")
                        .WithMany()
                        .HasForeignKey("InspectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IEP.Api.Model.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Inspector");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Sample", b =>
                {
                    b.HasOne("IEP.Api.Model.Entities.Client", null)
                        .WithMany("Samples")
                        .HasForeignKey("ClientId");

                    b.HasOne("IEP.Api.Model.Entities.Department", "Department")
                        .WithMany("Samples")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IEP.Api.Model.Entities.Inspector", "Inspector")
                        .WithMany("Samples")
                        .HasForeignKey("InspectorId");

                    b.HasOne("IEP.Api.Model.Entities.Job", null)
                        .WithMany("Samples")
                        .HasForeignKey("JobId");

                    b.HasOne("IEP.Api.Model.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Inspector");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Client", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Samples");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Department", b =>
                {
                    b.Navigation("Inspectors");

                    b.Navigation("Jobs");

                    b.Navigation("Samples");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Inspector", b =>
                {
                    b.Navigation("Samples");
                });

            modelBuilder.Entity("IEP.Api.Model.Entities.Job", b =>
                {
                    b.Navigation("Samples");
                });
#pragma warning restore 612, 618
        }
    }
}

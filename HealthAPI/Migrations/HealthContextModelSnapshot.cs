﻿// <auto-generated />
using HealthAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthAPI.Migrations
{
    [DbContext(typeof(HealthContext))]
    partial class HealthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthApi.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Address2");

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("DOB");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .HasMaxLength(255);

                    b.Property<string>("State");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("country")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("gender");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("nickName");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIHospital.Context;

#nullable disable

namespace WebAPIHospital.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240114030248_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPIHospital.Models.Analisis", b =>
                {
                    b.Property<int>("AnalisisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnalisisID"));

                    b.Property<DateTime>("FechaRealizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resultados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAnalisis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnalisisID");

                    b.ToTable("Analisis");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Autorizacion", b =>
                {
                    b.Property<int>("AutorizacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutorizacionID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAprobacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAutorizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorizacionID");

                    b.ToTable("Autorizaciones");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Cuenta", b =>
                {
                    b.Property<int>("CuentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuentaID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CuentaID");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("WebAPIHospital.Models.IngresoAlta", b =>
                {
                    b.Property<int>("IngresoAltaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoAltaID"));

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoIngreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngresoAltaID");

                    b.ToTable("IngresoAltas");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Perfil", b =>
                {
                    b.Property<int>("PerfilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerfilID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PerfilID");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Procedimiento", b =>
                {
                    b.Property<int>("ProcedimientoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcedimientoID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRealizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicoResponsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resultados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProcedimientoID");

                    b.ToTable("Procedimientos");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Transaccion", b =>
                {
                    b.Property<int>("TransaccionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransaccionID"));

                    b.Property<int>("CuentaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransaccionID");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("WebAPIHospital.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RollID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

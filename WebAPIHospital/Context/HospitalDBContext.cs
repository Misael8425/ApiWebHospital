using Microsoft.EntityFrameworkCore;
using System.Net;
using WebAPIHospital.Models;

namespace WebAPIHospital.Context
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        public DbSet<Analisis> Analisis { get; set; }
        public DbSet<Autorizacion> Autorizaciones { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<IngresoAlta> IngresoAltas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Procedimiento> Procedimientos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
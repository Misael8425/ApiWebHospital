namespace WebAPIHospital.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public int PerfilID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

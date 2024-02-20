namespace WebAPIHospital.Models
{
    public class Autorizacion
    {
        public int AutorizacionID { get; set; }
        public string PacienteCedula { get; set; }
        public string TipoAutorizacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAprobacion { get; set; }
    }
}

namespace WebAPIHospital.Models
{
    public class IngresoAlta
    {
        public int IngresoAltaID { get; set; }
        public string PacienteCedula { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAlta { get; set; }
        public string MotivoIngreso { get; set; }
    }
}

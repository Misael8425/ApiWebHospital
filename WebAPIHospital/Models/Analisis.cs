namespace WebAPIHospital.Models
{
    public class Analisis
    {
        public int AnalisisID { get; set; }
        public string PacienteCedula { get; set; }
        public string TipoAnalisis { get; set; }
        public string Resultados { get; set; }
        public DateTime FechaRealizacion { get; set; }
    }
}

namespace WebAPIHospital.Models
{
    public class Cuenta
    {
        public int CuentaID { get; set; }
        public string PacienteCedula { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

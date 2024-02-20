namespace WebAPIHospital.Models
{
    public class Transaccion
    {
        public int TransaccionID { get; set; }
        public int CuentaID { get; set; }
        public string TipoTransaccion { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaTransaccion { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIHospital.Models
{
    public class Procedimiento
    {
        public int ProcedimientoID { get; set; }
        public string PacienteCedula { get; set; }
        public int UsuarioID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public string Resultados { get; set; }
    }
}

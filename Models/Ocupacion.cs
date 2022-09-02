using System.ComponentModel.DataAnnotations;

namespace projectoOcupacion.Models
{
    public class Ocupacion
    {
        [Key]
        public int OcupacionId { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } 
        public Decimal Salario { get; set; } = 0;

        public Ocupacion(){
            this.OcupacionId = 0;
            this.FechaRegistro = DateTime.Now;
            this.Descripcion = string.Empty;
            this.Salario = 00;
        }

    }
}
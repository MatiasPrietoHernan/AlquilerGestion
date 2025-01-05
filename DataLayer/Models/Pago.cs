using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int HistorialAlquilerId { get; set; }
        public HistorialAlquiler HistorialAlquiler { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
    }
}

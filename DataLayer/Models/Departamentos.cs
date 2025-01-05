using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Materiales { get; set; }
        public string Dimensiones { get; set; }
        public string? Accesorios { get; set; }

    }
}

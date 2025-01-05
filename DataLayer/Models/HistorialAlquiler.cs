using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Models
{
    public class HistorialAlquiler
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public Departamentos Departamento { get; set; }
        public int InquilinoId { get; set; }
        public Inquilinos Inquilino { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int NumeroPersonas { get; set; }
    }
}

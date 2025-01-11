using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic.Interfaces;

namespace AlquilerGestion.Windows
{
    public partial class Pagos : Form
    {
        private readonly IPagosService pagosService;
        public Pagos(IPagosService _pagoService)
        {
            InitializeComponent();
            pagosService = _pagoService;
        }

        private async void Pagos_Load(object sender, EventArgs e)
        {
            var pagos = await pagosService.GetPagosConRelacionesAsync();
            var datos = pagos.Select(p => new
            {
                p.Id,
                Departamento = p.HistorialAlquiler?.Departamento?.Nombre ?? "Sin Nombre",
                Inquilino = p.HistorialAlquiler?.Inquilino?.Nombre ?? "Sin Nombre",
                p.Monto,
                p.FechaPago,
                p.MetodoPago
            }).ToList();

            dataGridView1.DataSource = datos;
        }
    }
}

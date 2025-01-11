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
    public partial class HistorialAlquilercs : Form
    {
        private readonly IAlquilerService alquilerService;
        public HistorialAlquilercs(IAlquilerService _alquilerService)
        {
            InitializeComponent();
            alquilerService = _alquilerService;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void HistorialAlquilercs_Load(object sender, EventArgs e)
        {
            var alquiler = await alquilerService.GetAlquilerWithRelationsAsnc();
            var datos = alquiler.Select(a => new
            {
                a.Id,
                Departamentos = a.Departamento?.Nombre ?? "Sin Nombre",
                Inquilinos = a.Inquilino?.Nombre ?? "Sin nombre",
                a.NumeroPersonas,
                a.FechaInicio,
                a.FechaFin
            }).ToList();
            dataGridView1.DataSource = datos;

        }
    }
}

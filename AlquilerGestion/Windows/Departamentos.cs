using BussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerGestion.Windows
{
    public partial class Departamentos : Form
    {
        private readonly IDepartamentosServices departamentosServices;
        public Departamentos(IDepartamentosServices _departamentosServices)
        {
            InitializeComponent();
            departamentosServices = _departamentosServices;
        }

        private async void Departamentos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await departamentosServices.GetAllDepartamentosAsync();
        }
    }
}

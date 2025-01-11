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
using BussinessLogic.Services;

namespace AlquilerGestion.Windows
{
    public partial class Inquilinos : Form
    {
        private readonly IInquilinosService inquilinosServices;

        public Inquilinos(IInquilinosService inquilinosServices)
        {
            InitializeComponent();
            this.inquilinosServices = inquilinosServices;
        }

        private async void Inquilinos_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = await inquilinosServices.GetAllInquilinosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

}

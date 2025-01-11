using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerGestion.SecondWindows;
using BussinessLogic.Interfaces;
using BussinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

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
                await CargarInquilinosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formInquilino = new FormInquilinos(Program.ServiceProvider.GetRequiredService<IInquilinosService>());

                formInquilino.FormClosed += async (s, args) => await CargarInquilinosAsync();
                formInquilino.Show();
            }
        }
        private async Task CargarInquilinosAsync()
        {
            try
            {
                dataGridView1.DataSource = null; // Limpia los datos previos
                dataGridView1.DataSource = await inquilinosServices.GetAllInquilinosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los inquilinos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formInquilino = new FormInquilinos(scope.ServiceProvider.GetRequiredService<IInquilinosService>());

                // Si hay un ID, buscamos el inquilino y lo pasamos para edición
                if (!string.IsNullOrWhiteSpace(textId.Text) && int.TryParse(textId.Text, out int id))
                {
                    var inquilino = inquilinosServices.GetInquilinoByIdAsync(id).Result; // Bloqueamos para obtener el objeto
                    if (inquilino != null)
                    {
                        formInquilino.InquilinoActual = inquilino;
                    }
                    else
                    {
                        MessageBox.Show("El inquilino seleccionado no existe, ¡revisá bien!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Si no hay ID, el formulario queda listo para agregar
                formInquilino.FormClosed += async (s, args) => await CargarInquilinosAsync();
                formInquilino.Show();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Aseguramos que no sea el encabezado
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                textId.Text = selectedRow.Cells["Id"].Value.ToString();
            }
        }

    }
}

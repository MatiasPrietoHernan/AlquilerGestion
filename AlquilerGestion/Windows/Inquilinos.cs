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

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Primero le preguntamos al usuario si está seguro
                var result = MessageBox.Show("¿Estás seguro de que querés eliminar este inquilino?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                // Si responde que sí, procedemos con la eliminación
                if (result == DialogResult.Yes)
                {
                    await inquilinosServices.DeleteInquilinoAsync(int.Parse(textId.Text));
                    await CargarInquilinosAsync();
                    MessageBox.Show("Inquilino eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el inquilino: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Aseguramos que no sea el encabezado
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                textId.Text = selectedRow.Cells["Id"].Value.ToString();
            }
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            var scope = Program.ServiceProvider.CreateScope();  // Creamos el scope afuera del using
            string idInquilinos = textId.Text;

            try
            {
                // Verificamos si el campo ID está vacío
                if (string.IsNullOrWhiteSpace(idInquilinos))
                {
                    MessageBox.Show("¡Tenés que seleccionar un inquilino para editar, boludo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Si no hay ID, no abro el formulario
                }

                var formInquilino = new FormInquilinos(scope.ServiceProvider.GetRequiredService<IInquilinosService>());

                // Si hay ID, buscamos el inquilino para editar
                if (int.TryParse(idInquilinos, out int id))
                {
                    var inquilino = await inquilinosServices.GetInquilinoByIdAsync(id);
                    if (inquilino != null)
                    {
                        formInquilino.InquilinoActual = inquilino;
                    }
                    else
                    {
                        MessageBox.Show("El inquilino seleccionado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                formInquilino.FormClosed += async (s, args) => await CargarInquilinosAsync();
                formInquilino.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

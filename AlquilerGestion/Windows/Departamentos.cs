using BussinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
using static System.Net.Mime.MediaTypeNames;
using DataLayer.Models;

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
            await CargarDepartamentosAsync();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var scope = Program.ServiceProvider.CreateScope();
            string idDepartmento = IdTxt.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(idDepartmento))
                {
                    MessageBox.Show("¡Tenés que seleccionar un Departamento para editar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Si no hay ID, no abro el formulario
                }
                var formDepartamentos = new FormDepartamentos(Program.ServiceProvider.GetRequiredService<IDepartamentosServices>());
                if (int.TryParse(idDepartmento, out int id))
                {
                    var departamentos = await departamentosServices.GetDepartamentosByIdAsync(id);
                    if (departamentos != null)
                    {
                        formDepartamentos.departamentoActual = departamentos;
                    }
                    else
                    {
                        MessageBox.Show("¡No se encontró el Departamento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                formDepartamentos.FormClosed += async (s, args) => await CargarDepartamentosAsync();
                formDepartamentos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formDepartamento = new FormDepartamentos(Program.ServiceProvider.GetRequiredService<IDepartamentosServices>());
                formDepartamento.FormClosed += async (s, args) => await CargarDepartamentosAsync();
                formDepartamento.Show();
            }
        }

        private async Task CargarDepartamentosAsync()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = await departamentosServices.GetAllDepartamentosAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Aseguramos que no sea el encabezado
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                IdTxt.Text = selectedRow.Cells["Id"].Value.ToString();
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("¿Estas seguro de eliminar este departamento?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await departamentosServices.DeleteDepartamentoAsync(int.Parse(IdTxt.Text));
                    await CargarDepartamentosAsync();
                    MessageBox.Show("Departamento eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el departamento: " + ex.Message);
            }
        }
    }
}

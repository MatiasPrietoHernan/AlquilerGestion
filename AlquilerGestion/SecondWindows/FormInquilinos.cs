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
using DataLayer.Models;
using static System.Net.Mime.MediaTypeNames;

namespace AlquilerGestion.SecondWindows
{
    public partial class FormInquilinos : Form
    {
        private readonly IInquilinosService inquilinosService;
        public Inquilinos InquilinoActual { get; set; }
        public FormInquilinos(IInquilinosService _inquilinosService)
        {
            InitializeComponent();
            inquilinosService = _inquilinosService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (InquilinoActual != null)
                {
                    // Modo editar
                    InquilinoActual.Nombre = textNombre.Text;
                    InquilinoActual.DNI = textDni.Text;
                    InquilinoActual.Telefono = textTelefono.Text;
                    InquilinoActual.Correo = textCorreo.Text;
                    InquilinoActual.Direccion = textDireccion.Text;

                    await inquilinosService.UpdateInquilinosAsync(InquilinoActual);
                    MessageBox.Show("Inquilino actualizado con éxito.");
                }
                else
                {
                    // Modo agregar
                    var nuevoInquilino = new DataLayer.Models.Inquilinos
                    {
                        Nombre = textNombre.Text,
                        DNI = textDni.Text,
                        Telefono = textTelefono.Text,
                        Correo = textCorreo.Text,
                        Direccion = textDireccion.Text
                    };

                    await inquilinosService.AddInquilinosAsync(nuevoInquilino);
                    MessageBox.Show("Inquilino agregado con éxito.");
                }

                this.Close(); // Cerramos el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInquilinos_Load(object sender, EventArgs e)
        {
            if (InquilinoActual != null)
            {
                textId.Text = InquilinoActual.Id.ToString();
                textNombre.Text = InquilinoActual.Nombre;
                textDni.Text = InquilinoActual.DNI;
                textTelefono.Text = InquilinoActual.Telefono;
                textCorreo.Text = InquilinoActual.Correo;
                textDireccion.Text = InquilinoActual.Direccion;

                textId.Enabled = false; // El ID no se puede modificar
            }
        }
    }
    }
}

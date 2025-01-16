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
using DataLayer.Models;

namespace AlquilerGestion.SecondWindows
{
    public partial class FormDepartamentos : Form
    {
        public Departamentos departamentoActual { get; set; }
        private readonly IDepartamentosServices departamentosServices;
        public FormDepartamentos(IDepartamentosServices _departamentos)
        {
            InitializeComponent();
            departamentosServices = _departamentos;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (departamentoActual != null)
                {
                    //Este es el modo editar papilo
                    departamentoActual.Nombre = nombreTxt.Text;
                    departamentoActual.Materiales = materialesTxt.Text;
                    departamentoActual.Dimensiones = dimensionesTxt.Text;
                    departamentoActual.Accesorios = accesoriosTxt.Text;

                    await departamentosServices.UpdateDepartamentoAsync(departamentoActual);
                    MessageBox.Show("Departamento actualizado con éxito.");
                }
                else
                {
                    //Este es el modo agregar papilo
                    var nuevoDepartamento = new Departamentos
                    {
                        Nombre = nombreTxt.Text,
                        Materiales = materialesTxt.Text,
                        Dimensiones = dimensionesTxt.Text,
                        Accesorios = accesoriosTxt.Text
                    };
                    await departamentosServices.AddDepartamentoAsync(nuevoDepartamento);
                    MessageBox.Show("Departamento agregado con éxito");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar o editar: " + ex.Message);
            }

        }

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            if(departamentoActual != null)
            {
                Idtxt.Text = departamentoActual.Id.ToString();
                nombreTxt.Text = departamentoActual.Nombre;
                materialesTxt.Text = departamentoActual.Materiales;
                dimensionesTxt.Text = departamentoActual.Dimensiones;
                accesoriosTxt.Text = departamentoActual.Accesorios;

                Idtxt.Enabled = false;
            }
        }
    }
}

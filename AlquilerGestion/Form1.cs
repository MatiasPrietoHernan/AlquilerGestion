using AlquilerGestion.Windows;
using BussinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AlquilerGestion
{
    public partial class Form1 : Form
    {
        private readonly IGlobalSearchServices globalSearch;
        public Form1(IGlobalSearchServices _globalSearch)
        {
            InitializeComponent();
            globalSearch = _globalSearch;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           using (var scope = Program.ServiceProvider.CreateScope())
            {
                var inquilino = new Inquilinos(Program.ServiceProvider.GetRequiredService<IInquilinosService>());

                this.Hide();

                // Mostrar la ventana Inquilinos
                inquilino.Show();

                // Registrar el evento de cierre de la ventana Inquilinos
                inquilino.FormClosed += (s, args) =>
                {
                    // Cuando Inquilinos se cierre, mostrar la ventana principal
                    this.Show();
                };
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var departamentos = new Departamentos(Program.ServiceProvider.GetRequiredService<IDepartamentosServices>());

                this.Hide();

                departamentos.Show();

                departamentos.FormClosed += (s, args) =>
                {
                    this.Show();
                };
            }

            
        }

        private void historialDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var alquiler = new HistorialAlquilercs(Program.ServiceProvider.GetRequiredService<IAlquilerService>());
                this.Hide();

                alquiler.Show();

                alquiler.FormClosed += (s, args) =>
                {
                    this.Show();
                };
            }

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var pagos = new Pagos(Program.ServiceProvider.GetRequiredService<IPagosService>());
                this.Hide();

                pagos.Show();

                pagos.FormClosed += (s, args) =>
                {
                    this.Show();
                };
            }

            
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();

            reportes.Show();


        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string term = textBox1.Text;

            try
            {
                var results = await globalSearch.BuscarGlobalAsync(term);
                dataGridView1.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

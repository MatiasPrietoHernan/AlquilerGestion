using AlquilerGestion.Windows;

namespace AlquilerGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inquilinos inquilino = new Inquilinos();
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

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();

            this.Hide();

            departamentos.Show();

            departamentos.FormClosed += (s, args) =>
            {
                this.Show();
            };
        }

        private void historialDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialAlquilercs alquilercs = new HistorialAlquilercs();

            this.Hide();

            alquilercs.Show();

            alquilercs.FormClosed += (s, args) =>
            {
                this.Show();
            };

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos();

            this.Hide();

            pago.Show();

            pago.FormClosed += (s, args) =>
            {
                this.Show();
            };
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();

            this.Hide();

            reportes.Show();

            reportes.FormClosed += (s, args) =>
            {
                this.Show();
            };
        }
    }
}

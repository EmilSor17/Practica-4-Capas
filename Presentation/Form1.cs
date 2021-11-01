using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncars_Click(object sender, EventArgs e)
        {
            fCarros fCarros = new fCarros();
            fCarros.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            fOrdenes ordenes = new fOrdenes();
            ordenes.Show();
        }

        private void btnmecanicos_Click(object sender, EventArgs e)
        {
            fMechanicals mechanicals = new fMechanicals();
            mechanicals.Show();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            fClientes client = new fClientes();
            client.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            fServicios servicios = new fServicios();
            servicios.Show();
        }
    }
}

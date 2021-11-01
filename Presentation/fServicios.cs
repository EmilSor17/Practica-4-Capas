using Domain_Repository.DTOs;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fServicios : Form
    {
        public fServicios()
        {
            InitializeComponent();
        }

        private void fServicios_Load(object sender, EventArgs e)
        {
            dgv();
        }

        void dgv()
        {
            dgvServicios.DataSource = Aplication_Repository.Service_Presentation.Service_Presentation.ShowService();
            btnEnableDisable.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCoste.Text) ||
                string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Ambos campos son obligatorios");
            }
            else
            {
                Add();
            }
        }
        void Add()
        {
            ServiceDTO service = new ServiceDTO
            {
                State = cbState.Checked,
                Name = txtName.Text,
                Coste = int.Parse(txtCoste.Text)
            };
            var dato = Aplication_Repository.Service_Presentation.Service_Presentation.AddService(service);
            if (dato)
            {
                MessageBox.Show("Agregado");
                dgv();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvServicios_Click(object sender, EventArgs e)
        {

        }
        void DisableEnable()
        {
            var id = int.Parse(dgvServicios.CurrentRow.Cells[0].Value.ToString());
            if (btnEnableDisable.Text == "Deshabilitar")
            {

                var dato = Aplication_Repository.Service_Presentation.Service_Presentation.DisableService(id);
                if (dato)
                {
                    MessageBox.Show("Deshabilitado");
                    dgv();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                var dato = Aplication_Repository.Service_Presentation.Service_Presentation.EnableService(id);
                if (dato)
                {
                    MessageBox.Show("Habilitado");
                    dgv();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            DisableEnable();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEnableDisable.Visible = true;
            if (Convert.ToBoolean(dgvServicios.CurrentRow.Cells["State"].Value.ToString()))
            {
                btnEnableDisable.Text = "Deshabilitar";
            }
            else
            {
                btnEnableDisable.Text = "Habilitar";
            }
        }
    }
}

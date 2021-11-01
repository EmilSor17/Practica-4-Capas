using Domain_Repository.DTOs;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fClientes : Form
    {
        public fClientes()
        {
            InitializeComponent();
        }

        private void fClientes_Load(object sender, EventArgs e)
        {
            dgv();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrEmpty(txtFirstName.Text)
                || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                AddClient();
            }

        }

        private void btnEbaleDisable_Click(object sender, EventArgs e)
        {
            btn();
        }


        private void dgvClient_Click(object sender, EventArgs e)
        {
            btnEbaleDisable.Visible = true;
            if (Convert.ToBoolean(dgvClient.CurrentRow.Cells["State"].Value))
            {
                btnEbaleDisable.Text = "Deshabilitar";
            }
            else
            {
                btnEbaleDisable.Text = "Habilitar";
            }
        }

        void dgv()
        {
            dgvClient.DataSource = Aplication_Repository.Client_Presentation.ClientPresentation.ShowClient();
            dgvClient.Columns["FirstName"].HeaderText = "Nombre";
            dgvClient.Columns["State"].HeaderText = "Estado";
            btnEbaleDisable.Visible = false;
        }
        void AddClient()
        {
            ClientDTO client = new ClientDTO
            {
                Id = txtCedula.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Fecha = dtpNac.Value,
                State = cbState.Checked
            };
            var dato = Aplication_Repository.Client_Presentation.ClientPresentation.AddClient(client);
            if (dato)
            {
                MessageBox.Show("Agregado");
                dgv();
            }
            else
            { MessageBox.Show("Error"); }
        }
        void btn()
        {
            var id = int.Parse(dgvClient.CurrentRow.Cells[0].Value.ToString());
            if (btnEbaleDisable.Text == "Deshabilitar")
            {
                var dato = Aplication_Repository.Client_Presentation.ClientPresentation.DisableClient(id);
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
                var dato = Aplication_Repository.Client_Presentation.ClientPresentation.EnableClient(id);
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
    }
}

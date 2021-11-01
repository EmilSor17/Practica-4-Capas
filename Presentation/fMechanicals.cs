using Domain_Repository.DTOs;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fMechanicals : Form
    {
        public fMechanicals()
        {
            InitializeComponent();
        }

        private void fMechanicals_Load(object sender, EventArgs e)
        {
            dgv();
        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            btn();
        }

        private void dgvMechanicals_Click(object sender, EventArgs e)
        {
            btnEnableDisable.Visible = true;
            if (Convert.ToBoolean(dgvMechanicals.CurrentRow.Cells["Status"].Value))
            {
                btnEnableDisable.Text = "Deshabilitar";
            }
            else
            {
                btnEnableDisable.Text = "Habilitar";
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text) ||
                string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(TxtTypeMechanical.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {

                AddMechanica();
            }
        }
        void btn()
        {

            int id = int.Parse(dgvMechanicals.CurrentRow.Cells[0].Value.ToString());
            var dato = false;
            if (btnEnableDisable.Text == "Deshabilitar")
            {
                dato = Aplication_Repository.MechanicalApplication.DisableMechanical(id);
                if (dato)
                {
                    MessageBox.Show("Deshabilitado");
                    btnEnableDisable.Visible = false;
                    dgv();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (btnEnableDisable.Text == "Habilitar")
            {
                dato = Aplication_Repository.MechanicalApplication.EnableMechanical(id);
                if (dato)
                {
                    MessageBox.Show("Habilitado");
                    btnEnableDisable.Visible = false;
                    dgv();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {

            }
        }
        void dgv()
        {
            btnEnableDisable.Visible = false;
            dgvMechanicals.DataSource = Aplication_Repository.MechanicalApplication.mechanicals();
            dgvMechanicals.Columns["FirstName"].HeaderText = "Nombre";
            dgvMechanicals.Columns["Type"].HeaderText = "Tipo";
            dgvMechanicals.Columns["Status"].HeaderText = "Estado";
            dgvMechanicals.Columns["LastName"].Visible = false;
            dgvMechanicals.Columns["Date"].HeaderText = "Fecha de Nacimiento";
            txtCedula.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            TxtTypeMechanical.Clear();
        }
        void AddMechanica()
        {
            MechanicalDTO Mechanical = new MechanicalDTO
            {
                Date = dtpDate.Value,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Type = TxtTypeMechanical.Text,
                Status = cbStatus.Checked,
                Id = txtCedula.Text

            };
            var dato = Aplication_Repository.MechanicalApplication.Addmechanicals(Mechanical);
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
    }
}

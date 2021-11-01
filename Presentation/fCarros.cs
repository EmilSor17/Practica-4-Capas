using Domain_Repository.DTOs;
using Domain_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fCarros : Form
    {
        public fCarros()
        {
            InitializeComponent();
        }

        private void fCarros_Load(object sender, EventArgs e)
        {
            cbbn();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbNombre.Text) ||
                string.IsNullOrEmpty(txtBrand.Text) ||
                string.IsNullOrEmpty(txtCarId.Text) ||
                string.IsNullOrEmpty(txtColor.Text) ||
                string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
            else
            {
                Add();
                Clear();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Clear();
            btnDeshabilitar.Visible = false;
            btnAgregar.Visible = true;
        }


        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnDisable();
        }
        void Clear()
        {
            txtBrand.Clear();
            txtCarId.Clear();
            txtYear.Clear();
            txtColor.Clear();
            txtModel.Clear();
            txtBrand.Enabled = true;
            txtCarId.Enabled = true;
            txtColor.Enabled = true;
            txtModel.Enabled = true;
            txtYear.Enabled = true;
            cbbNombre.Enabled = true;
            cbbNombre.Text = "";
            cbStatus.Enabled = true;

        }
        void Disable()
        {
            txtBrand.Enabled = false;
            txtCarId.Enabled = false;
            txtColor.Enabled = false;
            txtModel.Enabled = false;
            txtYear.Enabled = false;
            cbbNombre.Enabled = false;
            cbStatus.Enabled = false;
        }
        void cbbn()
        {
            dgvCars.DataSource = Aplication_Repository.ApplicationCars.ShowCars();
            dgvCars.Columns["Brand"].HeaderText = "Marca";
            dgvCars.Columns["Model"].HeaderText = "Modelo";
            dgvCars.Columns["Year"].HeaderText = "Año";
            dgvCars.Columns["FirstName"].HeaderText = "Cliente";
            dgvCars.Columns["CardId"].HeaderText = "Placa";
            dgvCars.Columns["Status"].HeaderText = "Estado";
            dgvCars.Columns["LastName"].Visible = false;
            List<cbbNameDTO> cbb = Aplication_Repository.ApplicationCars.cbb();
            var bs = new BindingSource();
            bs.DataSource = cbb;
            cbbNombre.DataSource = cbb;
            cbbNombre.DisplayMember = "FullName";
            cbbNombre.ValueMember = "Cedula";
            cbbNombre.Text = "";
            btnDeshabilitar.Visible = false;
            btnAgregar.Visible = true;
        }
        void Add()
        {
            if (string.IsNullOrEmpty(txtBrand.Text) ||
                string.IsNullOrEmpty(txtCarId.Text) ||
                string.IsNullOrEmpty(txtColor.Text) ||
                string.IsNullOrEmpty(txtYear.Text) ||
                string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(cbbNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                ECar car = new ECar
                {
                    Brand = txtBrand.Text,
                    Color = txtColor.Text,
                    CarId = txtCarId.Text,
                    Status = cbStatus.Checked,
                    Year = int.Parse(txtYear.Text),
                    Model = txtModel.Text,
                    UserId = cbbNombre.SelectedValue.ToString()
                };
                bool status = Aplication_Repository.ApplicationCars.AddCar(car);
                if (status)
                { cbbn(); MessageBox.Show("Agregado Correctamente"); }
                else
                { MessageBox.Show("Error"); }

            }
        }
        void GrabClient()
        {
            int id = int.Parse(dgvCars.CurrentRow.Cells[0].Value.ToString());
            txtBrand.Text = dgvCars.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dgvCars.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dgvCars.CurrentRow.Cells[3].Value.ToString();
            txtColor.Text = dgvCars.CurrentRow.Cells[4].Value.ToString();
            txtCarId.Text = dgvCars.CurrentRow.Cells[5].Value.ToString();
            cbbNombre.Text = dgvCars.CurrentRow.Cells[6].Value.ToString();
            cbStatus.Checked = Convert.ToBoolean(dgvCars.CurrentRow.Cells[8].Value);
        }
        void btnDisable()
        {
            var id = int.Parse(dgvCars.CurrentRow.Cells["Id"].Value.ToString());
            bool data = false;
            if (btnDeshabilitar.Text == "Deshabilitar")
            {
                data = Aplication_Repository.ApplicationCars.DisableCar(id);

                if (data)
                {
                    MessageBox.Show("Deshabilitado");
                    Clear();
                    cbbn();
                }
                else
                { MessageBox.Show("Error"); }
            }
            else
            {
                data = Aplication_Repository.ApplicationCars.EnableCar(id);
                if (data)
                {
                    MessageBox.Show("Habilitado");
                    Clear();
                    cbbn();
                }
                else
                { MessageBox.Show("Error"); }
            }


        }

        private void dgvCars_Click(object sender, EventArgs e)
        {
            btnDeshabilitar.Visible = true;
            btnAgregar.Visible = false;
            bool status = Convert.ToBoolean(dgvCars.CurrentRow.Cells["Status"].Value.ToString());
            if (status)
            { btnDeshabilitar.Text = "Deshabilitar"; }
            else
            { btnDeshabilitar.Text = "Habilitar"; }
            GrabClient();
            Disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            freport report = new freport();
            report.Show();
        }
    }
}

using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fOrdenes : Form
    {
        public fOrdenes()
        {
            InitializeComponent();
        }

        private void fOrdenes_Load(object sender, EventArgs e)
        {
            cbbsdgv();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbCarr.Text) ||
                string.IsNullOrEmpty(cbbClientt.Text) ||
                string.IsNullOrEmpty(cbbMecanichal.Text) ||
                string.IsNullOrEmpty(cbbServicio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                PlaceOrder();
            }
        }
        void PlaceOrder()
        {
            cbbOrderDTO order = new cbbOrderDTO
            {
                CarId = int.Parse(cbbCarr.SelectedValue.ToString()),
                Code = int.Parse(cbbServicio.SelectedValue.ToString()),
                ClienId = cbbClientt.SelectedValue.ToString(),
                Mid = int.Parse(cbbMecanichal.SelectedValue.ToString()),
                Date = dtpDate.Value
            };

            bool dato = Aplication_Repository.Order_Presentation.ApplicationOrder.PlaceOrder(order);
            if (dato)
            {
                MessageBox.Show("Agregado");
                cbbsdgv();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        void cbbsdgv()
        {
            dgvOrder.DataSource = Aplication_Repository.Order_Presentation.ApplicationOrder.order();
            dgvOrder.Columns["Brand"].HeaderText = "Marca";
            dgvOrder.Columns["Service"].HeaderText = "Servicio";
            dgvOrder.Columns["Coste"].HeaderText = "Costo";
            dgvOrder.Columns["MechanicalName"].HeaderText = "Mecanico";
            dgvOrder.Columns["ClientName"].HeaderText = "Cliente";
            dgvOrder.Columns["Date"].HeaderText = "Fecha";
            dgvOrder.Columns["Model"].HeaderText = "Modelo";
            List<cbbOrderDTO> cbbm = Aplication_Repository.Order_Presentation.ApplicationOrder.cbbm();
            cbbMecanichal.DataSource = cbbm;
            cbbMecanichal.DisplayMember = "MechanicalName";
            cbbMecanichal.ValueMember = "Mid";
            cbbMecanichal.Text = "";
            List<cbbOrderDTO> cbbClient = Aplication_Repository.Order_Presentation.ApplicationOrder.cbbcc();
            cbbClientt.DataSource = cbbClient;
            cbbClientt.DisplayMember = "ClientName";
            cbbClientt.ValueMember = "ClienId";
            cbbClientt.Text = "";
            List<cbbOrderDTO> cbbCar = Aplication_Repository.Order_Presentation.ApplicationOrder.cbbCar();
            cbbCarr.DataSource = cbbCar;
            cbbCarr.DisplayMember = "Car";
            cbbCarr.ValueMember = "CarId";
            cbbCarr.Text = "";
            List<cbbOrderDTO> cbbs = Aplication_Repository.Order_Presentation.ApplicationOrder.cbbs();
            cbbServicio.DataSource = cbbs;
            cbbServicio.DisplayMember = "ServiceName";
            cbbServicio.ValueMember = "Code";
            cbbServicio.Text = "";

        }
    }
}


namespace Presentation
{
    partial class fOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbServicio = new System.Windows.Forms.ComboBox();
            this.cbbMecanichal = new System.Windows.Forms.ComboBox();
            this.cbbClientt = new System.Windows.Forms.ComboBox();
            this.cbbCarr = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(259, 65);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(449, 150);
            this.dgvOrder.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbServicio
            // 
            this.cbbServicio.FormattingEnabled = true;
            this.cbbServicio.Location = new System.Drawing.Point(82, 76);
            this.cbbServicio.Name = "cbbServicio";
            this.cbbServicio.Size = new System.Drawing.Size(121, 21);
            this.cbbServicio.TabIndex = 2;
            // 
            // cbbMecanichal
            // 
            this.cbbMecanichal.FormattingEnabled = true;
            this.cbbMecanichal.Location = new System.Drawing.Point(82, 103);
            this.cbbMecanichal.Name = "cbbMecanichal";
            this.cbbMecanichal.Size = new System.Drawing.Size(121, 21);
            this.cbbMecanichal.TabIndex = 3;
            // 
            // cbbClientt
            // 
            this.cbbClientt.FormattingEnabled = true;
            this.cbbClientt.Location = new System.Drawing.Point(82, 130);
            this.cbbClientt.Name = "cbbClientt";
            this.cbbClientt.Size = new System.Drawing.Size(121, 21);
            this.cbbClientt.TabIndex = 4;
            // 
            // cbbCarr
            // 
            this.cbbCarr.FormattingEnabled = true;
            this.cbbCarr.Location = new System.Drawing.Point(82, 157);
            this.cbbCarr.Name = "cbbCarr";
            this.cbbCarr.Size = new System.Drawing.Size(121, 21);
            this.cbbCarr.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(82, 184);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mecanico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            // 
            // fOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbbCarr);
            this.Controls.Add(this.cbbClientt);
            this.Controls.Add(this.cbbMecanichal);
            this.Controls.Add(this.cbbServicio);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOrder);
            this.Name = "fOrdenes";
            this.Text = "fOrdenes";
            this.Load += new System.EventHandler(this.fOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbServicio;
        private System.Windows.Forms.ComboBox cbbMecanichal;
        private System.Windows.Forms.ComboBox cbbClientt;
        private System.Windows.Forms.ComboBox cbbCarr;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
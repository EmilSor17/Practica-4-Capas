
namespace Presentation
{
    partial class fServicios
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.Location = new System.Drawing.Point(259, 242);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(75, 23);
            this.btnEnableDisable.TabIndex = 1;
            this.btnEnableDisable.UseVisualStyleBackColor = true;
            this.btnEnableDisable.Click += new System.EventHandler(this.btnEnableDisable_Click);
            // 
            // cbState
            // 
            this.cbState.AutoSize = true;
            this.cbState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbState.Location = new System.Drawing.Point(45, 145);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(59, 17);
            this.cbState.TabIndex = 2;
            this.cbState.Text = "Estado";
            this.cbState.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(92, 119);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(100, 20);
            this.txtCoste.TabIndex = 4;
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(238, 54);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(440, 150);
            this.dgvServicios.TabIndex = 5;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            this.dgvServicios.Click += new System.EventHandler(this.dgvServicios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coste";
            // 
            // fServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.txtCoste);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.btnEnableDisable);
            this.Controls.Add(this.btnAdd);
            this.Name = "fServicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.fServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.CheckBox cbState;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCoste;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
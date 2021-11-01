
namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncars = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnmecanicos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncars
            // 
            this.btncars.Location = new System.Drawing.Point(80, 49);
            this.btncars.Name = "btncars";
            this.btncars.Size = new System.Drawing.Size(97, 23);
            this.btncars.TabIndex = 0;
            this.btncars.Text = "Menu Carros";
            this.btncars.UseVisualStyleBackColor = true;
            this.btncars.Click += new System.EventHandler(this.btncars_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(80, 78);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(97, 23);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Menu Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btncompras
            // 
            this.btncompras.Location = new System.Drawing.Point(80, 107);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(97, 23);
            this.btncompras.TabIndex = 2;
            this.btncompras.Text = "Menu Compras";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btnmecanicos
            // 
            this.btnmecanicos.Location = new System.Drawing.Point(80, 136);
            this.btnmecanicos.Name = "btnmecanicos";
            this.btnmecanicos.Size = new System.Drawing.Size(97, 23);
            this.btnmecanicos.TabIndex = 4;
            this.btnmecanicos.Text = "Menu Mecanicos";
            this.btnmecanicos.UseVisualStyleBackColor = true;
            this.btnmecanicos.Click += new System.EventHandler(this.btnmecanicos_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(80, 165);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(97, 23);
            this.btnServicios.TabIndex = 5;
            this.btnServicios.Text = "Menu Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 247);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnmecanicos);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.btncars);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncars;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnmecanicos;
        private System.Windows.Forms.Button btnServicios;
    }
}


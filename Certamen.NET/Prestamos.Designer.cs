
namespace Certamen.NET
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            this.saludo = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.datos2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuotascombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(12, 22);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(262, 42);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido , ";
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(687, 401);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(101, 37);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(328, 356);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(132, 54);
            this.btnConfirmarSolicitud.TabIndex = 3;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = true;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // datos2
            // 
            this.datos2.AutoSize = true;
            this.datos2.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos2.Location = new System.Drawing.Point(264, 107);
            this.datos2.Name = "datos2";
            this.datos2.Size = new System.Drawing.Size(245, 33);
            this.datos2.TabIndex = 5;
            this.datos2.Text = "Detalles del Prestamo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.monto);
            this.panel2.Controls.Add(this.cuotascombo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(193, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 172);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto del Prestamo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(234, 25);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(121, 20);
            this.monto.TabIndex = 2;
            this.monto.TextChanged += new System.EventHandler(this.monto_TextChanged);
            // 
            // cuotascombo
            // 
            this.cuotascombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotascombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotascombo.FormattingEnabled = true;
            this.cuotascombo.Location = new System.Drawing.Point(233, 73);
            this.cuotascombo.Name = "cuotascombo";
            this.cuotascombo.Size = new System.Drawing.Size(121, 21);
            this.cuotascombo.TabIndex = 1;
            this.cuotascombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuotas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datos2);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Del Prestamo";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label datos2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuotascombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
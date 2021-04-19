
namespace Certamen.NET
{
    partial class caja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caja));
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.botonsimular = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // nombre
            // 
            resources.ApplyResources(this.nombre, "nombre");
            this.errorProvider1.SetError(this.nombre, resources.GetString("nombre.Error"));
            this.errorProvider1.SetIconAlignment(this.nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("nombre.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.nombre, ((int)(resources.GetObject("nombre.IconPadding"))));
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            resources.ApplyResources(this.apellido, "apellido");
            this.errorProvider1.SetError(this.apellido, resources.GetString("apellido.Error"));
            this.errorProvider1.SetIconAlignment(this.apellido, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("apellido.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.apellido, ((int)(resources.GetObject("apellido.IconPadding"))));
            this.apellido.Name = "apellido";
            // 
            // txtnombre
            // 
            resources.ApplyResources(this.txtnombre, "txtnombre");
            this.errorProvider1.SetError(this.txtnombre, resources.GetString("txtnombre.Error"));
            this.errorProvider1.SetIconAlignment(this.txtnombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtnombre.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtnombre, ((int)(resources.GetObject("txtnombre.IconPadding"))));
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // botonsimular
            // 
            resources.ApplyResources(this.botonsimular, "botonsimular");
            this.errorProvider1.SetError(this.botonsimular, resources.GetString("botonsimular.Error"));
            this.errorProvider1.SetIconAlignment(this.botonsimular, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("botonsimular.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.botonsimular, ((int)(resources.GetObject("botonsimular.IconPadding"))));
            this.botonsimular.Name = "botonsimular";
            this.botonsimular.UseVisualStyleBackColor = true;
            this.botonsimular.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            resources.ApplyResources(this.salir, "salir");
            this.errorProvider1.SetError(this.salir, resources.GetString("salir.Error"));
            this.errorProvider1.SetIconAlignment(this.salir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("salir.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.salir, ((int)(resources.GetObject("salir.IconPadding"))));
            this.salir.Name = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtapellido
            // 
            resources.ApplyResources(this.txtapellido, "txtapellido");
            this.errorProvider1.SetError(this.txtapellido, resources.GetString("txtapellido.Error"));
            this.errorProvider1.SetIconAlignment(this.txtapellido, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtapellido.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtapellido, ((int)(resources.GetObject("txtapellido.IconPadding"))));
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // caja
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.salir);
            this.Controls.Add(this.botonsimular);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "caja";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.botonsimular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button botonsimular;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


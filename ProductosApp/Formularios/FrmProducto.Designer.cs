namespace ProductosApp.Formularios
{
    partial class FrmProducto
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Descripcion = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.Label();
			this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
			this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
			this.nudPrecio = new System.Windows.Forms.NumericUpDown();
			this.nudExistencia = new System.Windows.Forms.NumericUpDown();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.Descripcion);
			this.groupBox1.Controls.Add(this.Nombre);
			this.groupBox1.Controls.Add(this.cmbUnidadMedida);
			this.groupBox1.Controls.Add(this.dtpCaducidad);
			this.groupBox1.Controls.Add(this.nudPrecio);
			this.groupBox1.Controls.Add(this.nudExistencia);
			this.groupBox1.Controls.Add(this.txtDesc);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Location = new System.Drawing.Point(25, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(508, 373);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos productos";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 317);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Unidad de Medida";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 277);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Fecha Vencimiento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Precio";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Existencia";
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSize = true;
			this.Descripcion.Location = new System.Drawing.Point(36, 126);
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Size = new System.Drawing.Size(63, 13);
			this.Descripcion.TabIndex = 7;
			this.Descripcion.Text = "Descripcion";
			// 
			// Nombre
			// 
			this.Nombre.AutoSize = true;
			this.Nombre.Location = new System.Drawing.Point(36, 42);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(44, 13);
			this.Nombre.TabIndex = 6;
			this.Nombre.Text = "Nombre";
			this.Nombre.Click += new System.EventHandler(this.Label1_Click);
			// 
			// cmbUnidadMedida
			// 
			this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnidadMedida.FormattingEnabled = true;
			this.cmbUnidadMedida.Location = new System.Drawing.Point(170, 311);
			this.cmbUnidadMedida.Name = "cmbUnidadMedida";
			this.cmbUnidadMedida.Size = new System.Drawing.Size(219, 21);
			this.cmbUnidadMedida.TabIndex = 5;
			// 
			// dtpCaducidad
			// 
			this.dtpCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCaducidad.Location = new System.Drawing.Point(170, 273);
			this.dtpCaducidad.Name = "dtpCaducidad";
			this.dtpCaducidad.Size = new System.Drawing.Size(219, 20);
			this.dtpCaducidad.TabIndex = 4;
			// 
			// nudPrecio
			// 
			this.nudPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPrecio.DecimalPlaces = 2;
			this.nudPrecio.Location = new System.Drawing.Point(170, 237);
			this.nudPrecio.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPrecio.Name = "nudPrecio";
			this.nudPrecio.Size = new System.Drawing.Size(139, 20);
			this.nudPrecio.TabIndex = 3;
			this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudExistencia
			// 
			this.nudExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudExistencia.Location = new System.Drawing.Point(170, 189);
			this.nudExistencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudExistencia.Name = "nudExistencia";
			this.nudExistencia.Size = new System.Drawing.Size(139, 20);
			this.nudExistencia.TabIndex = 2;
			// 
			// txtDesc
			// 
			this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc.Location = new System.Drawing.Point(170, 88);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(216, 79);
			this.txtDesc.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Location = new System.Drawing.Point(170, 41);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(216, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
			this.flowLayoutPanel1.Controls.Add(this.btnAceptar);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 407);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 39);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(430, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 0;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(349, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
			// 
			// FrmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 450);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmProducto";
			this.Text = "FrmProducto";
			this.Load += new System.EventHandler(this.FrmProducto_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
		public System.Windows.Forms.ComboBox cmbUnidadMedida;
		public System.Windows.Forms.DateTimePicker dtpCaducidad;
		public System.Windows.Forms.NumericUpDown nudPrecio;
		public System.Windows.Forms.NumericUpDown nudExistencia;
		public System.Windows.Forms.TextBox txtDesc;
		public System.Windows.Forms.TextBox txtNombre;
	}
}
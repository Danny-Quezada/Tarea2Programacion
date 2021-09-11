
namespace ProductosApp.Formularios
{
	partial class ActualizarProducto
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
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnActualizar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtID);
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
			this.groupBox1.Location = new System.Drawing.Point(46, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(558, 410);
			this.groupBox1.TabIndex = 1;
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
			// 
			// cmbUnidadMedida
			// 
			this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnidadMedida.FormattingEnabled = true;
			this.cmbUnidadMedida.Location = new System.Drawing.Point(170, 311);
			this.cmbUnidadMedida.Name = "cmbUnidadMedida";
			this.cmbUnidadMedida.Size = new System.Drawing.Size(269, 21);
			this.cmbUnidadMedida.TabIndex = 5;
			// 
			// dtpCaducidad
			// 
			this.dtpCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCaducidad.Location = new System.Drawing.Point(170, 273);
			this.dtpCaducidad.Name = "dtpCaducidad";
			this.dtpCaducidad.Size = new System.Drawing.Size(269, 20);
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
			this.nudPrecio.Size = new System.Drawing.Size(189, 20);
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
			this.nudExistencia.Size = new System.Drawing.Size(189, 20);
			this.nudExistencia.TabIndex = 2;
			// 
			// txtDesc
			// 
			this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc.Location = new System.Drawing.Point(170, 88);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(266, 79);
			this.txtDesc.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Location = new System.Drawing.Point(170, 41);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(266, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(451, 39);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(492, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "ID:";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(267, 369);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 14;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// ActualizarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "ActualizarProducto";
			this.Text = "ActualizarProducto";
			this.Load += new System.EventHandler(this.ActualizarProducto_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
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
		public System.Windows.Forms.ComboBox cmbUnidadMedida;
		public System.Windows.Forms.DateTimePicker dtpCaducidad;
		public System.Windows.Forms.NumericUpDown nudPrecio;
		public System.Windows.Forms.NumericUpDown nudExistencia;
		public System.Windows.Forms.TextBox txtDesc;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnActualizar;
	}
}
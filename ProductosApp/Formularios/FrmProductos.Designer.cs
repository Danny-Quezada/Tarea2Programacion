namespace ProductosApp.Formularios
{
    partial class FrmProductos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbFinderType = new System.Windows.Forms.ComboBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nudPrecioInferior = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioSuperior = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioInferior = new System.Windows.Forms.Label();
            this.lblPrecioSuperior = new System.Windows.Forms.Label();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.btnCerrarApp = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnCerrarApp);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 381);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(673, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(567, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(461, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // cmbFinderType
            // 
            this.cmbFinderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinderType.FormattingEnabled = true;
            this.cmbFinderType.Items.AddRange(new object[] {
            "Unidad Medida",
            "Rango Precio",
            "Fecha Vencimiento",
            "Buscar ID"});
            this.cmbFinderType.Location = new System.Drawing.Point(24, 24);
            this.cmbFinderType.Name = "cmbFinderType";
            this.cmbFinderType.Size = new System.Drawing.Size(191, 21);
            this.cmbFinderType.TabIndex = 1;
            this.cmbFinderType.SelectedIndexChanged += new System.EventHandler(this.CmbFinderType_SelectedIndexChanged);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(324, 22);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(192, 21);
            this.cmbUnidadMedida.TabIndex = 2;
            // 
            // txtFinder
            // 
            this.txtFinder.Location = new System.Drawing.Point(363, 24);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(123, 20);
            this.txtFinder.TabIndex = 3;
            this.txtFinder.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtFinder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinder_KeyPress);
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(12, 51);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(773, 324);
            this.rtbProductView.TabIndex = 4;
            this.rtbProductView.Text = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // nudPrecioInferior
            // 
            this.nudPrecioInferior.Location = new System.Drawing.Point(276, 25);
            this.nudPrecioInferior.Name = "nudPrecioInferior";
            this.nudPrecioInferior.Size = new System.Drawing.Size(146, 20);
            this.nudPrecioInferior.TabIndex = 6;
            this.nudPrecioInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecioInferior_KeyPress);
            // 
            // nudPrecioSuperior
            // 
            this.nudPrecioSuperior.Location = new System.Drawing.Point(428, 25);
            this.nudPrecioSuperior.Name = "nudPrecioSuperior";
            this.nudPrecioSuperior.Size = new System.Drawing.Size(145, 20);
            this.nudPrecioSuperior.TabIndex = 7;
            this.nudPrecioSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecioSuperior_KeyPress);
            // 
            // lblPrecioInferior
            // 
            this.lblPrecioInferior.AutoSize = true;
            this.lblPrecioInferior.Location = new System.Drawing.Point(312, 7);
            this.lblPrecioInferior.Name = "lblPrecioInferior";
            this.lblPrecioInferior.Size = new System.Drawing.Size(71, 13);
            this.lblPrecioInferior.TabIndex = 8;
            this.lblPrecioInferior.Text = "Precio inferior";
            // 
            // lblPrecioSuperior
            // 
            this.lblPrecioSuperior.AutoSize = true;
            this.lblPrecioSuperior.Location = new System.Drawing.Point(461, 7);
            this.lblPrecioSuperior.Name = "lblPrecioSuperior";
            this.lblPrecioSuperior.Size = new System.Drawing.Size(77, 13);
            this.lblPrecioSuperior.TabIndex = 9;
            this.lblPrecioSuperior.Text = "Precio superior";
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(324, 25);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCaducidad.TabIndex = 10;
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Location = new System.Drawing.Point(355, 3);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(100, 30);
            this.btnCerrarApp.TabIndex = 3;
            this.btnCerrarApp.Text = "Cerrar app";
            this.btnCerrarApp.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaCaducidad);
            this.Controls.Add(this.lblPrecioSuperior);
            this.Controls.Add(this.lblPrecioInferior);
            this.Controls.Add(this.nudPrecioSuperior);
            this.Controls.Add(this.nudPrecioInferior);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.txtFinder);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.cmbFinderType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinderType;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.TextBox txtFinder;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudPrecioInferior;
        private System.Windows.Forms.NumericUpDown nudPrecioSuperior;
        private System.Windows.Forms.Label lblPrecioInferior;
        private System.Windows.Forms.Label lblPrecioSuperior;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.Button btnCerrarApp;
    }
}
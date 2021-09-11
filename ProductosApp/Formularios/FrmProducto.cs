using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{

    public partial class FrmProducto : Form
	{
		public ProductoModel pModel { get; set; }
		public FrmFindID find { get; set; }
      
		public FrmProducto()
        {
            find = new FrmFindID(pModel);
            pModel = new ProductoModel();
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
		{
			cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
			
		}

		private void BtnAceptar_Click(object sender, EventArgs e)
        {

			if (string.IsNullOrWhiteSpace(txtDesc.Text) ||
             string.IsNullOrWhiteSpace(txtNombre.Text) ||
             nudExistencia.Value == 0 ||
             nudPrecio.Value == 0 ||
             string.IsNullOrWhiteSpace(cmbUnidadMedida.Text))
			{
                MessageBox.Show("Error, llenar todos los campos");
                return;
			}

            string descripcion = txtDesc.Text;
                string nombre = txtNombre.Text;
                decimal precio = nudPrecio.Value;
                int existencia = (int)nudExistencia.Value;
                UnidadMedida unidad = (UnidadMedida)cmbUnidadMedida.SelectedIndex;
                DateTime vencimiento = dtpCaducidad.Value;

                Producto p = new Producto();
                p.Descripcion = descripcion;
                p.Id = pModel.GetLastProductoId() + 1;
                p.Nombre = nombre;
                p.Precio = precio;
                p.Existencia = existencia;
                p.UnidadMedida = unidad;
                p.Vencimiento = vencimiento;

                pModel.Add(p);
                MessageBox.Show($"{pModel.productos.Length}");

                Dispose();
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
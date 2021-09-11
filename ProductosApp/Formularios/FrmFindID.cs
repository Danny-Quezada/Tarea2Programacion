using Domain.Entities;
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
	public partial class FrmFindID : Form
	{
		public int i { get; set; }
		public ProductoModel pmodel { get; set; }
		public Producto PP { get; set; }
		
		public FrmFindID(ProductoModel p)
		{
	
			PP = new Producto();
			pmodel = new ProductoModel();
			InitializeComponent();
			this.pmodel = p; //Hago esto para que se almacena el valor de ProductoModel que esta en FrmProductos para poder tener el arreglo de FrmProducto aqui
		}
		
		private void btnBuscar_Click(object sender, EventArgs e)
		{

			i = int.Parse(txtFindID.Text);
			if (pmodel.GetProductoById(i)==null)
			{
				MessageBox.Show("Error, no existe este producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				btnEliminar.Enabled = true;
				btnActualizar.Enabled = true;
				 PP = pmodel.GetProductoById(i);
			}

		}

		private void FrmFindID_Load(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

			
			pmodel.DeleteBy(PP);
			Dispose();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ActualizarProducto p = new ActualizarProducto();
			 p.Pmodel=pmodel;
			p.txtNombre.Text = $"{PP.Nombre}";
			p.txtDesc.Text = $"{PP.Descripcion}";
			p.nudExistencia.Value = PP.Existencia;
			p.nudPrecio.Value = PP.Precio;
			p.cmbUnidadMedida.SelectedItem = PP.UnidadMedida;
			p.txtID.Text = $"{PP.Id}";
			p.ShowDialog();
			Dispose();
		}
	}
}

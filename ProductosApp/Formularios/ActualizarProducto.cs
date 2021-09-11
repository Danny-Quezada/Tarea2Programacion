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
	public partial class ActualizarProducto : Form
	{
		public ProductoModel Pmodel { get; set; }
				public ActualizarProducto()
		{
			Pmodel = new ProductoModel();
			InitializeComponent();
		
		}

		private void ActualizarProducto_Load(object sender, EventArgs e)
		{

			cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			string descripcion = txtDesc.Text;
			string nombre = txtNombre.Text;
			decimal precio = nudPrecio.Value;
			int existencia = (int)nudExistencia.Value;
			UnidadMedida unidad = (UnidadMedida)cmbUnidadMedida.SelectedIndex;
			DateTime vencimiento = dtpCaducidad.Value;

			Producto p = new Producto();
			p.Descripcion = descripcion;
			p.Id =int.Parse(txtID.Text);
			p.Nombre = nombre;
			p.Precio = precio;
			p.Existencia = existencia;
			p.UnidadMedida = unidad;
			p.Vencimiento = vencimiento;


			Pmodel.Update(p);
			Dispose();
		}
	}
}

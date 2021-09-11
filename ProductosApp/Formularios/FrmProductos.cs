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
    public partial class FrmProductos : Form
    {
        private ProductoModel productoModel;

        public FrmProductos()
        {

            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
        }

        private void CmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            FrmProducto frmProducto = new FrmProducto();
            frmProducto.pModel = productoModel;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoModel.GetProductosAsJson();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmFindID frmFindId = new FrmFindID(productoModel);

			frmFindId.pmodel = productoModel;
            frmFindId.btnActualizar.Visible = true;

            frmFindId.ShowDialog();
            rtbProductView.Text = productoModel.GetProductosAsJson();   
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            FrmFindID frmFindId = new FrmFindID(productoModel);

			frmFindId.pmodel = productoModel;
            frmFindId.btnEliminar.Visible = true;
            frmFindId.ShowDialog();
            
            rtbProductView.Text = productoModel.GetProductosAsJson();
            
        }
    }
}

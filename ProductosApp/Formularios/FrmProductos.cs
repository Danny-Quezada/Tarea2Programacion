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
            cmbUnidadMedida.Visible = false;
            txtFinder.Visible = false;
            nudPrecioInferior.Visible = false;
            nudPrecioSuperior.Visible = false;
            dtpFechaCaducidad.Visible = false;
            lblPrecioInferior.Visible = false;
            lblPrecioSuperior.Visible = false;
        }

        private void CmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFinderType.SelectedIndex == 0)
            {
                txtFinder.Visible = true;
                nudPrecioInferior.Visible = false;
                nudPrecioSuperior.Visible = false;
                cmbUnidadMedida.Visible = false;
                dtpFechaCaducidad.Visible = false;
                lblPrecioInferior.Visible = false;
                lblPrecioSuperior.Visible = false;
            }
            if (cmbFinderType.SelectedIndex == 1)
            {
                nudPrecioInferior.Visible = true;
                nudPrecioSuperior.Visible = true;
                lblPrecioInferior.Visible = true;
                lblPrecioSuperior.Visible = true;
                cmbUnidadMedida.Visible = false;
                txtFinder.Visible = false;
                dtpFechaCaducidad.Visible = false;
            }
            if (cmbFinderType.SelectedIndex == 2)
            {
                cmbUnidadMedida.Visible = true;
                txtFinder.Visible = false;
                nudPrecioInferior.Visible = false;
                nudPrecioSuperior.Visible = false;
                lblPrecioInferior.Visible = false;
				lblPrecioSuperior.Visible = false;
                dtpFechaCaducidad.Visible = false;
			}
			if (cmbFinderType.SelectedIndex == 3)
            {
                dtpFechaCaducidad.Visible = true;
                cmbUnidadMedida.Visible = false;
                txtFinder.Visible = false;
                nudPrecioInferior.Visible = false;
                nudPrecioSuperior.Visible = false;
                lblPrecioInferior.Visible = false;
                lblPrecioSuperior.Visible = false;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            FrmProducto frmProducto = new FrmProducto();
            frmProducto.pModel = productoModel;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoModel.GetProductosAsJson();
        }
        private int ValidarPrecios(decimal a, decimal b)
        {
            if (a < b || a == b)
            {
                return 1;
            }
            if (a > b)
            {
                return -1;
            }
            return 0;
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

        private void txtFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            MessageBox.Show("Solo debe de ingresar números", "Error en el id", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void nudPrecioInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void nudPrecioSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbFinderType.SelectedIndex == 0)
            {
                int.TryParse(txtFinder.Text, out int id);
                if (id > 0 || txtFinder.Text != "")
                {
                    Producto Tempo = productoModel.GetProductoById(id);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                    }
                    else
                    {
                        rtbProductView.Text = $"Id: {Tempo.Id}, Nombre: {Tempo.Nombre}, Descripcion: {Tempo.Descripcion}, Cantidad: {Tempo.Existencia}, Precio: {Tempo.Precio}, Caducidad: {Tempo.Vencimiento}, Unidad de medida: {Tempo.UnidadMedida}";
                    }
                }
            }
            if (cmbFinderType.SelectedIndex == 1)
            {
                int pivote = ValidarPrecios(nudPrecioInferior.Value, nudPrecioSuperior.Value);
                if (pivote == 1)
                {
                    Producto[] Tempo = productoModel.GetProductosByRangoPrecio(nudPrecioInferior.Value, nudPrecioSuperior.Value);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < Tempo.Length; i++)
                        {
                            string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].Vencimiento}, Unidad de medida: {Tempo[i].UnidadMedida}";
                            rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                        }
                        return;
                    }
                }
                MessageBox.Show("Para realizar la busqueda debe de cambiar los valores", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudPrecioInferior.Value = 0;
                nudPrecioSuperior.Value = 0;
            }
            if (cmbFinderType.SelectedIndex == 2)
            {
                if (cmbUnidadMedida.Text == string.Empty)
                {
                    MessageBox.Show("Debe de ingresar una unidad de medida", "Error con la unidad de medida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto[] Tempo = productoModel.GetProductosByUnidadMedida((UnidadMedida)cmbUnidadMedida.SelectedIndex);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                    }
                    else
                    {
                        for (int i = 0; i < Tempo.Length; i++)
                        {
                            string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].Vencimiento}, Unidad de medida: {Tempo[i].UnidadMedida}";
                            rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                        }
                    }
                }
            }
            if (cmbFinderType.SelectedIndex == 3)
            {
                Producto[] Tempo = productoModel.GetProductosByFechaVencimiento(dtpFechaCaducidad.Value);
                rtbProductView.Text = "";
                if (Tempo == null)
                {
                    rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                }
                else
                {
                    for (int i = 0; i < Tempo.Length; i++)
                    {
                        string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].Vencimiento   }, Unidad de medida: {Tempo[i].UnidadMedida}";
                        rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                    }
                }
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

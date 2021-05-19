using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();

        private ProductoOperations productoOperations = ProductoOperations.Instance();
        private Producto producto;
        //cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();
        }

        //cuando es modificar el producto
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = productoOperations.GetById(idProducto);

            txtID.Text = producto.idProducto.ToString();
            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            txtCosto.Text = producto.costo.ToString();
            txtPrecio.Text = producto.precio.ToString();
            lupCategoria.EditValue = producto.idCategoria.ToString();
            lupColor.EditValue = producto.idColor.ToString();
            lupMarca.EditValue = producto.idMarca.ToString();
            txtStock.Text = producto.stock.ToString();

        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (productoOperations.Add(new Producto
                    {
                        codigo = txtCodigo.Text,
                        descripcion = txtDescripcion.Text,
                        costo = Convert.ToDecimal(txtCosto.Text),
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        idCategoria = Convert.ToInt32(lupCategoria.EditValue),
                        idColor = Convert.ToInt32(lupColor.EditValue),
                        idMarca = Convert.ToInt32(lupMarca.EditValue),
                        stock = Convert.ToInt32(txtStock.Text)
                    }) > 0)
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la inserción", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    producto.codigo = txtCodigo.Text;
                    producto.descripcion = txtDescripcion.Text;
                    producto.costo = Convert.ToDecimal(txtCosto.Text);
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.idCategoria = Convert.ToInt32(lupCategoria.EditValue);
                    producto.idColor = Convert.ToInt32(lupColor.EditValue);
                    producto.idMarca = Convert.ToInt32(lupMarca.EditValue);
                    producto.stock = Convert.ToInt32(txtStock.Text);

                    if (productoOperations.Update(producto) > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la modificación", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresa un código";
                txtCodigo.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa una descripción";
                if (!ban)
                {
                    txtDescripcion.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                txtCosto.ErrorText = "Ingresa un costo";
                if (!ban)
                {
                    txtCosto.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresa un precio";
                if (!ban)
                {
                    txtPrecio.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(lupCategoria.Text))
            {
                lupCategoria.ErrorText = "Ingresa una categoria";
                if (!ban)
                {
                    lupCategoria.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(lupColor.Text))
            {
                lupColor.ErrorText = "Ingresa un color";
                if (!ban)
                {
                    lupColor.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(lupMarca.Text))
            {
                lupMarca.ErrorText = "Ingresa una marca";
                if (!ban)
                {
                    lupMarca.Focus();
                    ban = true;
                }
            }

            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresa un stock";
                if (!ban)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }


            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
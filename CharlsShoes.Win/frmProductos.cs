using CharlsShoes.BLL;
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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();

        private ProductoOperations productoOperations = ProductoOperations.Instance();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto()
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.GetFocusedRowCellValue("idProducto") != null)
            {
                new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
                {
                    Text = "Modificar Producto (" + (int)gvProductos.GetFocusedRowCellValue("idProducto") + ")"
                }.ShowDialog();
                productoBindingSource.DataSource = productoOperations.GetAll();
                gvProductos.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un producto a modificar", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el producto? \n\n" +
                    "{0}", gvProductos.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (productoOperations.Delete((int)gvProductos.GetFocusedRowCellValue("idProducto")) > 0)
                    {
                        XtraMessageBox.Show("Producto eliminado correctamente", "Charls Shoes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el producto. \nVerifique con el deparamento de TI",
                            "Charls Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    productoBindingSource.DataSource = productoOperations.GetAll();
                    gvProductos.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvProductos.BestFitColumns();
        }
    }
}
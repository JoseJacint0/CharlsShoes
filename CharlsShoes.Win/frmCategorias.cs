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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria()
            {
                Text = "Nueva Categoría"
            }.ShowDialog();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvCategorias.GetFocusedRowCellValue("idCategoria") != null)
            {
                new frmNMCategoria((int)gvCategorias.GetFocusedRowCellValue("idCategoria"))
                {
                    Text = "Modificar Categoria (" + (int)gvCategorias.GetFocusedRowCellValue("idCategoria") + ")"
                }.ShowDialog();
                categoriaBindingSource.DataSource = categoriaOperations.GetAll();
                gvCategorias.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un empleado a modificar", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvCategorias.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la categoria? \n\n" +
                    "{0}", gvCategorias.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (categoriaOperations.Delete((int)gvCategorias.GetFocusedRowCellValue("idCategoria")) > 0)
                    {
                        XtraMessageBox.Show("Categoria eliminada correctamente", "Charls Shoes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la categoría. \nVerifique con el deparamento de TI",
                            "Charls Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoriaBindingSource.DataSource = categoriaOperations.GetAll();
                    gvCategorias.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }
    }
}
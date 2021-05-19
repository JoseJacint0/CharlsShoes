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
    public partial class frmColores : DevExpress.XtraEditors.XtraForm
    {
        private ColorOperations colorOperations = ColorOperations.Instance();
        public frmColores()
        {
            InitializeComponent();
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMColor()
            {
                Text = "Nuevo Color"
            }.ShowDialog();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvColores.GetFocusedRowCellValue("idColor") != null)
            {
                new frmNMColor((int)gvColores.GetFocusedRowCellValue("idColor"))
                {
                    Text = "Modificar Color (" + (int)gvColores.GetFocusedRowCellValue("idColor") + ")"
                }.ShowDialog();
                colorBindingSource.DataSource = colorOperations.GetAll();
                gvColores.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un color a modificar", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvColores.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el color? \n\n" +
                    "{0}", gvColores.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (colorOperations.Delete((int)gvColores.GetFocusedRowCellValue("idColor")) > 0)
                    {
                        XtraMessageBox.Show("Color eliminado correctamente", "Charls Shoes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el color. \nVerifique con el deparamento de TI",
                            "Charls Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    colorBindingSource.DataSource = colorOperations.GetAll();
                    gvColores.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }
    }
}
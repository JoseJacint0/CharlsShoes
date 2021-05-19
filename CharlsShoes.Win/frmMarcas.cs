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
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMMarca()
            {
                Text = "Nueva Marca"
            }.ShowDialog();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMarcas.GetFocusedRowCellValue("idMarca") != null)
            {
                new frmNMMarca((int)gvMarcas.GetFocusedRowCellValue("idMarca"))
                {
                    Text = "Modificar Marca (" + (int)gvMarcas.GetFocusedRowCellValue("idMarca") + ")"
                }.ShowDialog();
                marcaBindingSource.DataSource = marcaOperations.GetAll();
                gvMarcas.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó una marca a modificar", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMarcas.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la marca? \n\n" +
                    "{0}", gvMarcas.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (marcaOperations.Delete((int)gvMarcas.GetFocusedRowCellValue("idMarca")) > 0)
                    {
                        XtraMessageBox.Show("Marca eliminada correctamente", "Charls Shoes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la marca. \nVerifique con el deparamento de TI",
                            "Charls Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marcaBindingSource.DataSource = marcaOperations.GetAll();
                    gvMarcas.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }
    }
}
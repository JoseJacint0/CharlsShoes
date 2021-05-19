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
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente()
            {
                Text = "Nueva Cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvClientes.GetFocusedRowCellValue("idCliente") != null)
            {
                new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
                {
                    Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("idCliente") + ")"
                }.ShowDialog();
                clienteBindingSource.DataSource = clienteOperations.GetAll();
                gvClientes.BestFitColumns();
            }
            else
            {
                XtraMessageBox.Show("No se seleccionó un cliente a modificar", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvClientes.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el cliente? \n\n" +
                    "{0}", gvClientes.GetFocusedRowCellValue("nombre")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (clienteOperations.Delete((int)gvClientes.GetFocusedRowCellValue("idCliente")) > 0)
                    {
                        XtraMessageBox.Show("Cliente eliminado correctamente", "Charls Shoes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el cliente. \nVerifique con el deparamento de TI",
                            "Charls Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clienteBindingSource.DataSource = clienteOperations.GetAll();
                    gvClientes.BestFitColumns();
                }
        }
    }
}
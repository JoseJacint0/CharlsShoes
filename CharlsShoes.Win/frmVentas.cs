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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        private VentaOperations ventaOperations = VentaOperations.Instance();
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            ventaBindingSource.DataSource = ventaOperations.GetAll();
            gvVentas.BestFitColumns(); 
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            productoBindingSource.DataSource = productoOperations.GetAll();
            ventaBindingSource.DataSource = ventaOperations.GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnCancelarVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
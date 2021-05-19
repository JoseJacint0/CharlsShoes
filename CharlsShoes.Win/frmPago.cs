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
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            Clean();
            txtTotPag.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtCambio.EditValue = 0;
        }

        private void Clean()
        {
            txtTotPag.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            Misc.pago = Convert.ToDecimal(txtPago.EditValue);
            txtCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (txtPago.EditValue != null)
                    if (Convert.ToDouble(txtPago.EditValue) > 0)
                    {
                        txtCambio.EditValue = (Misc.totalPago - Convert.ToDecimal(txtPago.EditValue)) * -1;
                        btnRegistrarVenta.Focus();
                    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
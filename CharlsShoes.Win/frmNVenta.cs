using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        private VentaOperations ventaOperations = VentaOperations.Instance();
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        private decimal subtotal, descuento, total;
        private List<VentaDetalle> ventasDetalle = new List<VentaDetalle>();
        private Cliente cliente;
        private int cnt = 0;

        public frmNVenta()
        {
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Inicializando una venta ...");
            InitializeComponent();
        }

        private void gvVentaDetalle_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ventaDetalleBindingSource.DataSource = ventasDetalle;
            gvVentaDetalle.BestFitColumns();
        }

        private void gControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvVentaDetalle_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Totales();
        }

        private void gvVentaDetalle_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            switch ((sender as GridView).FocusedColumn.FieldName)
            {
                case "cantidad":
                    e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Cantidad";
                    e.ErrorText = "La cantidad debe ser mayor a 0";
                    break;
                case "dv":
                    e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Descuento de venta";
                    e.ErrorText = "La cantidad debe ser mayor o igual a 0 y menor que 100";
                    break;
                case "dv2":
                    e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Descuento de venta";
                    e.ErrorText = "La cantidad debe ser mayor o igual a 0";
                    break;
            }

            //Destroying the editor and discarding the changes made within the edited cell.
            gvVentaDetalle.HideEditor();
        }

        private void gvVentaDetalle_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (!decimal.TryParse(e.Value.ToString(), out decimal r))
            {
                //e.ErrorText = "Solo se admiten valores númericos";
                e.Valid = false;
                return;
            }
            decimal valorcelda = Convert.ToDecimal(e.Value);
            decimal precio = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("precio"));
            decimal dc = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("dc"));
            decimal dv = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("dv"));
            decimal dv2 = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("dv2"));
            decimal importe = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("importe"));
            decimal descuento = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("descuento"));
            decimal total = Convert.ToDecimal(gvVentaDetalle.GetFocusedRowCellValue("total"));
            switch ((sender as GridView).FocusedColumn.FieldName)
            {
                case "cantidad":
                    if(valorcelda < 1 || valorcelda > 1000000)
                    {
                        //e.ErrorText = "No se permiten valores menores a 1 y mayores a 1000000";
                        e.Valid = false;
                        return;
                    }
                    importe = precio * valorcelda;
                    descuento = ((dc + dv) * importe) * dv2;
                    total = importe - descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["importe"] = importe;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["descuento"] = descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["total"] = total;
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "importe", importe);
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "total", total);
                    break;
                case "dv":
                    if (valorcelda < 0 || valorcelda > 100)
                    {
                        //e.ErrorText = "No se permiten valores menores a 0 y mayores a 1000000";
                        e.Valid = false;
                        return;
                    }
                    e.Value = valorcelda / 100;
                    valorcelda = Convert.ToDecimal(e.Value);
                    descuento = ((dc + valorcelda) * importe) + dv2;
                    total = importe - descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["descuento"] = descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["total"] = total;
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "total", total);
                    break;
                case "dv2":
                    if (valorcelda < 0 || valorcelda > 1000000)
                    {
                        e.Valid = false;
                        return;
                    }
                    descuento = ((dc + dv) * importe) + valorcelda;
                    total = importe - descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["descuento"] = descuento;
                    //dtVentaDetalle.Rows[gvVentaDetalle.FocusedRowHandle]["total"] = total;
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentaDetalle.SetRowCellValue(gvVentaDetalle.FocusedRowHandle, "total", total);
                    break;
            }
            Totales();
        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCodigo.EditValue == null)
                    return;
                if (lupCliente.EditValue == null)
                {
                    txtCodigo.EditValue = null;
                    return;
                }
                Producto producto = productoOperations.GetByCodigo(txtCodigo.Text);
                if(producto == null)
                {
                    txtCodigo.EditValue = null;
                    txtCodigo.Focus();
                    return;
                }
                foreach (var item in ventasDetalle)
                    if (item.idProducto == producto.idProducto)
                    {
                        item.cantidad += 1;
                        item.importe = item.precio * item.cantidad;
                        item.descuento = ((item.dc + item.dv) * item.importe) + item.dv2;
                        item.total = item.importe - item.descuento;
                        ventaDetalleBindingSource.DataSource = ventasDetalle;
                        gvVentaDetalle.BestFitColumns();
                        Totales();
                        txtCodigo.EditValue = null;
                        txtCodigo.Focus();
                        return;
                    }
                cliente = clienteOperations.GetById((int)lupCliente.EditValue);
                ventasDetalle.Add(new VentaDetalle
                {
                    idProducto = producto.idProducto,
                    cantidad = 1,
                    precio = producto.precio,
                    importe = producto.precio,
                    dc = cliente.descuento,
                    dv = 0,
                    dv2 = 0,
                    descuento = (cliente.descuento * producto.precio),
                    total = producto.precio - (cliente.descuento * producto.precio)
                });
                ventaDetalleBindingSource.DataSource = ventasDetalle;
                gvVentaDetalle.BestFitColumns();
                Totales();
                txtCodigo.EditValue = null;
                txtCodigo.Focus();
                if (ventasDetalle.Count > 0)
                    lupCliente.Enabled = false;
                else
                    lupCliente.Enabled = true;
            }
        }

        private void frmNVenta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    if (ventasDetalle.Count == 0)
                        return;
                    gvVentaDetalle.CloseEditor();
                    gvVentaDetalle.UpdateCurrentRow();
                    if (new frmPago().ShowDialog() == DialogResult.OK)
                    {
                        Totales();
                        //cnt = Convert.ToInt32(gvVentaDetalle.Columns["cantidad"].SummaryItem.SummaryValue);
                        Venta venta = ventaOperations.Add(new Venta
                        {
                            folio = 0,
                            idCliente = (int)lupCliente.EditValue,
                            fecha = DateTime.Now,
                            cantidad = cnt,
                            importe = subtotal,
                            descuento = descuento,
                            total = Misc.totalPago,
                            pago = Misc.pago,
                            status = "A",
                            idUsuario = Misc.usuario.idUsuario,
                            ventasDetalle = ventasDetalle
                        });
                        if (venta != null)
                        {
                            XtraMessageBox.Show("Venta registrada correctamente", "Charls Shoes", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            try
                            {
                                //StiReport stiReport = new StiReport();
                                //stiReport.LoadFromString(reporteOperations.GetByName("Ticket").xml);
                                //stiReport.Dictionary.Databases.Clear();
                                //stiReport.Dictionary.Databases.Add(new StiSqlDatabase("softwell", SoftwellLiteContext.conString));
                                //stiReport.Dictionary.Variables.Add(new StiVariable("idVenta", venta.idVenta));
                                //stiReport.Print(false);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                throw new ApplicationException("Error " + ex.Message);
                            }
                        }
                    }
                    break;
            }
        }

        private void gvVentaDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridHitInfo hitInfo = gridView.CalcHitInfo(e.Location);
            if (hitInfo.Column == null || hitInfo.Column.FieldName == "Value") return;
            this.BeginInvoke(new MethodInvoker(delegate { gridView.ShowEditorByMouse(); }));
        }

        private void gcVentaDetalle_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
                if (XtraMessageBox.Show("¿Deseas eliminar el renglón?", "Charls Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Handled = true;
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            productoBindingSource.DataSource = productoOperations.GetAll();
            ventaDetalleBindingSource.DataSource = ventasDetalle;
            Misc.totalPago = 0;
            Misc.pago = 0;
            SplashScreenManager.CloseDefaultWaitForm();
        }

        

        private void Totales()
        {
            subtotal = 0;
            descuento = 0;
            total = 0;
            cnt = 0;
            foreach (var item in ventasDetalle)
            {
                subtotal += item.importe;
                descuento += item.descuento;
                total += item.total;
                cnt = cnt + item.cantidad;
            }
            Misc.totalPago = total;
            lblTotalSub.Text = subtotal.ToString("c");
            lblTotalDescuento.Text = descuento.ToString("c");
            lblTotalTotal.Text = total.ToString("c");
            lblTotalPago.Text = Misc.pago.ToString("c");
            lblTotalCambio.Text = Misc.pago != 0 ? ((Misc.totalPago - Misc.pago) * -1).ToString("c") : 0.ToString("c");
        }
    }
}
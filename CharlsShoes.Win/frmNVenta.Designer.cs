
namespace CharlsShoes.Win
{
    partial class frmNVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.gControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lupCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.gControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.gControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalPago = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSub = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcVentaDetalle = new DevExpress.XtraGrid.GridControl();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentaDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVentaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).BeginInit();
            this.gControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl2)).BeginInit();
            this.gControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl3)).BeginInit();
            this.gControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gControl1
            // 
            this.gControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl1.Controls.Add(this.lupCliente);
            this.gControl1.Controls.Add(this.lblCliente);
            this.gControl1.Location = new System.Drawing.Point(5, 12);
            this.gControl1.Name = "gControl1";
            this.gControl1.Size = new System.Drawing.Size(1054, 43);
            this.gControl1.TabIndex = 0;
            // 
            // lupCliente
            // 
            this.lupCliente.Location = new System.Drawing.Point(47, 12);
            this.lupCliente.Name = "lupCliente";
            this.lupCliente.Properties.AccessibleName = "";
            this.lupCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoP", "apellido P", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoM", "apellido M", 56, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descuento", "descuento", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupCliente.Properties.DataSource = this.clienteBindingSource;
            this.lupCliente.Properties.DisplayMember = "nombre";
            this.lupCliente.Properties.NullText = "";
            this.lupCliente.Properties.ShowFooter = false;
            this.lupCliente.Properties.ShowHeader = false;
            this.lupCliente.Properties.ValueMember = "idCliente";
            this.lupCliente.Size = new System.Drawing.Size(215, 20);
            this.lupCliente.TabIndex = 1;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CharlsShoes.Entities.Cliente);
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(4, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // gControl2
            // 
            this.gControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl2.Controls.Add(this.txtCodigo);
            this.gControl2.Controls.Add(this.lblCodigo);
            this.gControl2.Location = new System.Drawing.Point(5, 61);
            this.gControl2.Name = "gControl2";
            this.gControl2.Size = new System.Drawing.Size(1054, 78);
            this.gControl2.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(47, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(215, 40);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.EditValueChanged += new System.EventHandler(this.txtCodigo_EditValueChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(4, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // gControl3
            // 
            this.gControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl3.Controls.Add(this.lblTotalCambio);
            this.gControl3.Controls.Add(this.lblTotalPago);
            this.gControl3.Controls.Add(this.lblTotalTotal);
            this.gControl3.Controls.Add(this.lblTotalDescuento);
            this.gControl3.Controls.Add(this.lblTotalSub);
            this.gControl3.Controls.Add(this.lblPago);
            this.gControl3.Controls.Add(this.lblDescuento);
            this.gControl3.Controls.Add(this.lblCambio);
            this.gControl3.Controls.Add(this.lblTotal);
            this.gControl3.Controls.Add(this.lblSubTotal);
            this.gControl3.Location = new System.Drawing.Point(5, 622);
            this.gControl3.Name = "gControl3";
            this.gControl3.Size = new System.Drawing.Size(1054, 78);
            this.gControl3.TabIndex = 2;
            this.gControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.gControl3_Paint);
            // 
            // lblTotalCambio
            // 
            this.lblTotalCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCambio.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalCambio.Appearance.Options.UseFont = true;
            this.lblTotalCambio.Appearance.Options.UseForeColor = true;
            this.lblTotalCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalCambio.Location = new System.Drawing.Point(929, 42);
            this.lblTotalCambio.Name = "lblTotalCambio";
            this.lblTotalCambio.Size = new System.Drawing.Size(118, 13);
            this.lblTotalCambio.TabIndex = 13;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Appearance.Options.UseFont = true;
            this.lblTotalPago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalPago.Location = new System.Drawing.Point(929, 7);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(118, 13);
            this.lblTotalPago.TabIndex = 12;
            // 
            // lblTotalTotal
            // 
            this.lblTotalTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTotal.Appearance.Options.UseFont = true;
            this.lblTotalTotal.Appearance.Options.UseForeColor = true;
            this.lblTotalTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalTotal.Location = new System.Drawing.Point(601, 6);
            this.lblTotalTotal.Name = "lblTotalTotal";
            this.lblTotalTotal.Size = new System.Drawing.Size(120, 13);
            this.lblTotalTotal.TabIndex = 11;
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuento.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDescuento.Appearance.Options.UseFont = true;
            this.lblTotalDescuento.Appearance.Options.UseForeColor = true;
            this.lblTotalDescuento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalDescuento.Location = new System.Drawing.Point(319, 8);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(116, 13);
            this.lblTotalDescuento.TabIndex = 10;
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSub.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSub.Appearance.Options.UseFont = true;
            this.lblTotalSub.Appearance.Options.UseForeColor = true;
            this.lblTotalSub.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalSub.Location = new System.Drawing.Point(71, 13);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(109, 13);
            this.lblTotalSub.TabIndex = 9;
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.Location = new System.Drawing.Point(866, 5);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(57, 16);
            this.lblPago.TabIndex = 8;
            this.lblPago.Text = "Su Pago:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Appearance.Options.UseFont = true;
            this.lblDescuento.Location = new System.Drawing.Point(239, 7);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(74, 16);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Location = new System.Drawing.Point(852, 42);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(71, 16);
            this.lblCambio.TabIndex = 6;
            this.lblCambio.Text = "Su Cambio:";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Appearance.Options.UseFont = true;
            this.lblSubTotal.Location = new System.Drawing.Point(4, 13);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(61, 16);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // gcVentaDetalle
            // 
            this.gcVentaDetalle.DataSource = this.ventaDetalleBindingSource;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcVentaDetalle.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcVentaDetalle_EmbeddedNavigator_ButtonClick);
            this.gcVentaDetalle.Location = new System.Drawing.Point(5, 145);
            this.gcVentaDetalle.MainView = this.gvVentaDetalle;
            this.gcVentaDetalle.Name = "gcVentaDetalle";
            this.gcVentaDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupProductos});
            this.gcVentaDetalle.Size = new System.Drawing.Size(1054, 471);
            this.gcVentaDetalle.TabIndex = 3;
            this.gcVentaDetalle.UseEmbeddedNavigator = true;
            this.gcVentaDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentaDetalle});
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataSource = typeof(CharlsShoes.Entities.VentaDetalle);
            // 
            // gvVentaDetalle
            // 
            this.gvVentaDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentaDetalle.Appearance.Row.Options.UseFont = true;
            this.gvVentaDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVentaDetalle,
            this.colidVenta,
            this.colidProducto,
            this.colcantidad,
            this.colprecio,
            this.colimporte,
            this.coldc,
            this.coldv,
            this.coldv2,
            this.coldescuento,
            this.coltotal,
            this.colventa});
            this.gvVentaDetalle.GridControl = this.gcVentaDetalle;
            this.gvVentaDetalle.Name = "gvVentaDetalle";
            this.gvVentaDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentaDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentaDetalle.OptionsView.ShowFooter = true;
            this.gvVentaDetalle.OptionsView.ShowGroupPanel = false;
            this.gvVentaDetalle.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvVentaDetalle_RowDeleted);
            this.gvVentaDetalle.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvVentaDetalle_ValidateRow);
            this.gvVentaDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvVentaDetalle_MouseDown);
            this.gvVentaDetalle.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvVentaDetalle_ValidatingEditor);
            this.gvVentaDetalle.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gvVentaDetalle_InvalidValueException);
            // 
            // colidVentaDetalle
            // 
            this.colidVentaDetalle.FieldName = "idVentaDetalle";
            this.colidVentaDetalle.Name = "colidVentaDetalle";
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.rlupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.OptionsColumn.AllowEdit = false;
            this.colidProducto.OptionsColumn.AllowFocus = false;
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 1;
            // 
            // rlupProductos
            // 
            this.rlupProductos.AutoHeight = false;
            this.rlupProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProductos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProducto", "id Producto", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Producto", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("costo", "costo", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("precio", "precio", 38, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 67, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idColor", "id Color", 45, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("stock", "stock", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupProductos.DataSource = this.productoBindingSource;
            this.rlupProductos.DisplayMember = "descripcion";
            this.rlupProductos.Name = "rlupProductos";
            this.rlupProductos.NullText = "";
            this.rlupProductos.PopupSizeable = false;
            this.rlupProductos.ShowFooter = false;
            this.rlupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CharlsShoes.Entities.Producto);
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cnt";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "{0:#.##} Pzas.")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 0;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.AllowEdit = false;
            this.colprecio.OptionsColumn.AllowFocus = false;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.OptionsColumn.AllowFocus = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 3;
            // 
            // coldc
            // 
            this.coldc.Caption = "DC";
            this.coldc.DisplayFormat.FormatString = "P1";
            this.coldc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldc.FieldName = "dc";
            this.coldc.Name = "coldc";
            this.coldc.OptionsColumn.AllowEdit = false;
            this.coldc.OptionsColumn.AllowFocus = false;
            this.coldc.Visible = true;
            this.coldc.VisibleIndex = 4;
            // 
            // coldv
            // 
            this.coldv.Caption = "DV";
            this.coldv.DisplayFormat.FormatString = "P1";
            this.coldv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv.FieldName = "dv";
            this.coldv.Name = "coldv";
            this.coldv.Visible = true;
            this.coldv.VisibleIndex = 5;
            // 
            // coldv2
            // 
            this.coldv2.Caption = "DV2";
            this.coldv2.DisplayFormat.FormatString = "c";
            this.coldv2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv2.FieldName = "dv2";
            this.coldv2.Name = "coldv2";
            this.coldv2.Visible = true;
            this.coldv2.VisibleIndex = 6;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Desc";
            this.coldescuento.DisplayFormat.FormatString = "c";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.OptionsColumn.AllowEdit = false;
            this.coldescuento.OptionsColumn.AllowFocus = false;
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 7;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "c";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowFocus = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            // 
            // colventa
            // 
            this.colventa.FieldName = "venta";
            this.colventa.Name = "colventa";
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 712);
            this.Controls.Add(this.gcVentaDetalle);
            this.Controls.Add(this.gControl3);
            this.Controls.Add(this.gControl2);
            this.Controls.Add(this.gControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNVenta.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).EndInit();
            this.gControl1.ResumeLayout(false);
            this.gControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl2)).EndInit();
            this.gControl2.ResumeLayout(false);
            this.gControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl3)).EndInit();
            this.gControl3.ResumeLayout(false);
            this.gControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gControl1;
        private DevExpress.XtraEditors.LookUpEdit lupCliente;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraEditors.GroupControl gControl2;
        private DevExpress.XtraEditors.GroupControl gControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblTotalSub;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.LabelControl lblTotalCambio;
        private DevExpress.XtraEditors.LabelControl lblTotalPago;
        private DevExpress.XtraEditors.LabelControl lblTotalTotal;
        private DevExpress.XtraEditors.LabelControl lblTotalDescuento;
        private DevExpress.XtraGrid.GridControl gcVentaDetalle;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldc;
        private DevExpress.XtraGrid.Columns.GridColumn coldv;
        private DevExpress.XtraGrid.Columns.GridColumn coldv2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colventa;
    }
}
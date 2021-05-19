
namespace CharlsShoes.Win
{
    partial class frmVentas
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.gvVentasDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVentaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupClientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevaVenta = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirTicket = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirRemision = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelarVenta = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVentasDetalle
            // 
            this.gvVentasDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVentaDetalle,
            this.colidVenta1,
            this.colidProducto,
            this.colcantidad1,
            this.colprecio,
            this.colimporte1,
            this.coldc,
            this.coldv,
            this.coldv2,
            this.coldescuento1,
            this.coltotal1,
            this.colventa});
            this.gvVentasDetalle.GridControl = this.gcVentas;
            this.gvVentasDetalle.Name = "gvVentasDetalle";
            this.gvVentasDetalle.OptionsBehavior.Editable = false;
            this.gvVentasDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentasDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentasDetalle.OptionsView.ShowGroupPanel = false;
            this.gvVentasDetalle.ViewCaption = "Detalle Venta";
            // 
            // colidVentaDetalle
            // 
            this.colidVentaDetalle.FieldName = "idVentaDetalle";
            this.colidVentaDetalle.Name = "colidVentaDetalle";
            // 
            // colidVenta1
            // 
            this.colidVenta1.FieldName = "idVenta";
            this.colidVenta1.Name = "colidVenta1";
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.rlupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            // 
            // rlupProductos
            // 
            this.rlupProductos.AutoHeight = false;
            this.rlupProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProductos.DataSource = this.productoBindingSource;
            this.rlupProductos.DisplayMember = "descripcion";
            this.rlupProductos.Name = "rlupProductos";
            this.rlupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CharlsShoes.Entities.Producto);
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Cantidad";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 1;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            // 
            // colimporte1
            // 
            this.colimporte1.Caption = "Importe";
            this.colimporte1.DisplayFormat.FormatString = "c";
            this.colimporte1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte1.FieldName = "importe";
            this.colimporte1.Name = "colimporte1";
            this.colimporte1.Visible = true;
            this.colimporte1.VisibleIndex = 3;
            // 
            // coldc
            // 
            this.coldc.Caption = "DC";
            this.coldc.DisplayFormat.FormatString = "P2";
            this.coldc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldc.FieldName = "dc";
            this.coldc.Name = "coldc";
            this.coldc.Visible = true;
            this.coldc.VisibleIndex = 4;
            // 
            // coldv
            // 
            this.coldv.Caption = "DV";
            this.coldv.DisplayFormat.FormatString = "P2";
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
            // coldescuento1
            // 
            this.coldescuento1.Caption = "Descuento";
            this.coldescuento1.DisplayFormat.FormatString = "c";
            this.coldescuento1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento1.FieldName = "descuento";
            this.coldescuento1.Name = "coldescuento1";
            this.coldescuento1.Visible = true;
            this.coldescuento1.VisibleIndex = 7;
            // 
            // coltotal1
            // 
            this.coltotal1.Caption = "Total";
            this.coltotal1.DisplayFormat.FormatString = "c";
            this.coltotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal1.FieldName = "total";
            this.coltotal1.Name = "coltotal1";
            this.coltotal1.Visible = true;
            this.coltotal1.VisibleIndex = 8;
            // 
            // colventa
            // 
            this.colventa.FieldName = "venta";
            this.colventa.Name = "colventa";
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvVentasDetalle;
            gridLevelNode1.RelationName = "ventasDetalle";
            this.gcVentas.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcVentas.Location = new System.Drawing.Point(0, 24);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.bManager;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupClientes,
            this.rlupUsuarios,
            this.rlupProductos});
            this.gcVentas.Size = new System.Drawing.Size(1184, 337);
            this.gcVentas.TabIndex = 4;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas,
            this.gvVentasDetalle});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(CharlsShoes.Entities.Venta);
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colfolio,
            this.colidCliente,
            this.colfecha,
            this.colcantidad,
            this.colimporte,
            this.coldescuento,
            this.coltotal,
            this.colpago,
            this.colstatus,
            this.colidUsuario});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            // 
            // colfolio
            // 
            this.colfolio.Caption = "Folio";
            this.colfolio.FieldName = "folio";
            this.colfolio.Name = "colfolio";
            this.colfolio.Visible = true;
            this.colfolio.VisibleIndex = 0;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.ColumnEdit = this.rlupClientes;
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 1;
            // 
            // rlupClientes
            // 
            this.rlupClientes.AutoHeight = false;
            this.rlupClientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupClientes.DataSource = this.clienteBindingSource;
            this.rlupClientes.DisplayMember = "nombre";
            this.rlupClientes.Name = "rlupClientes";
            this.rlupClientes.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CharlsShoes.Entities.Cliente);
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.DisplayFormat.FormatString = "c";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "c";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            // 
            // colpago
            // 
            this.colpago.Caption = "Pago";
            this.colpago.DisplayFormat.FormatString = "c";
            this.colpago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago.FieldName = "pago";
            this.colpago.Name = "colpago";
            this.colpago.Visible = true;
            this.colpago.VisibleIndex = 7;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 8;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Usuario";
            this.colidUsuario.ColumnEdit = this.rlupUsuarios;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 9;
            // 
            // rlupUsuarios
            // 
            this.rlupUsuarios.AutoHeight = false;
            this.rlupUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupUsuarios.DataSource = this.usuarioBindingSource;
            this.rlupUsuarios.DisplayMember = "nombre";
            this.rlupUsuarios.Name = "rlupUsuarios";
            this.rlupUsuarios.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(CharlsShoes.Entities.Usuario);
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevaVenta,
            this.btnImprimirTicket,
            this.btnImprimirRemision,
            this.btnCancelarVenta});
            this.bManager.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevaVenta, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirTicket, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirRemision, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelarVenta, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Caption = "Nueva Venta";
            this.btnNuevaVenta.Id = 1;
            this.btnNuevaVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.ImageOptions.Image")));
            this.btnNuevaVenta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.ImageOptions.LargeImage")));
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevaVenta_ItemClick);
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Caption = "Imprimir Ticket";
            this.btnImprimirTicket.Id = 2;
            this.btnImprimirTicket.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirTicket.ImageOptions.SvgImage")));
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            // 
            // btnImprimirRemision
            // 
            this.btnImprimirRemision.Caption = "Imprimir Remisión";
            this.btnImprimirRemision.Id = 3;
            this.btnImprimirRemision.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirRemision.ImageOptions.SvgImage")));
            this.btnImprimirRemision.Name = "btnImprimirRemision";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Caption = "Cancelar Venta";
            this.btnCancelarVenta.Id = 4;
            this.btnCancelarVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarVenta.ImageOptions.Image")));
            this.btnCancelarVenta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarVenta.ImageOptions.LargeImage")));
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelarVenta_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1184, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Manager = this.bManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1184, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.bManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1184, 24);
            this.barDockControlRight.Manager = this.bManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmVentas.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevaVenta;
        private DevExpress.XtraBars.BarButtonItem btnImprimirTicket;
        private DevExpress.XtraBars.BarButtonItem btnImprimirRemision;
        private DevExpress.XtraBars.BarButtonItem btnCancelarVenta;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentasDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colpago;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte1;
        private DevExpress.XtraGrid.Columns.GridColumn coldc;
        private DevExpress.XtraGrid.Columns.GridColumn coldv;
        private DevExpress.XtraGrid.Columns.GridColumn coldv2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colventa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}
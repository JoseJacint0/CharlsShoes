
namespace CharlsShoes.Win
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnImprimirRemision = new DevExpress.XtraBars.BarButtonItem();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupMarca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlupColor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlupCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnImprimirRemision});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // btnImprimirRemision
            // 
            this.btnImprimirRemision.Caption = "Imprimir Remisión";
            this.btnImprimirRemision.Id = 4;
            this.btnImprimirRemision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirRemision.ImageOptions.Image")));
            this.btnImprimirRemision.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImprimirRemision.ImageOptions.LargeImage")));
            this.btnImprimirRemision.Name = "btnImprimirRemision";
            // 
            // gcProductos
            // 
            this.gcProductos.DataSource = this.productoBindingSource;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.Location = new System.Drawing.Point(0, 24);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.MenuManager = this.barManager1;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupMarca,
            this.rlupColor,
            this.rlupCategoria});
            this.gcProductos.Size = new System.Drawing.Size(798, 524);
            this.gcProductos.TabIndex = 6;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CharlsShoes.Entities.Producto);
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProducto,
            this.colcodigo,
            this.coldescripcion,
            this.colcosto,
            this.colprecio,
            this.colidCategoria,
            this.colidColor,
            this.colidMarca,
            this.colstock,
            this.colactivo});
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsView.ColumnAutoWidth = false;
            this.gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductos.OptionsView.ShowAutoFilterRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "ID";
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.OptionsColumn.AllowEdit = false;
            this.colidProducto.OptionsColumn.AllowFocus = false;
            this.colidProducto.OptionsColumn.AllowIncrementalSearch = false;
            this.colidProducto.OptionsColumn.AllowMove = false;
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.OptionsColumn.AllowFocus = false;
            this.colcodigo.OptionsColumn.AllowIncrementalSearch = false;
            this.colcodigo.OptionsColumn.AllowMove = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.OptionsColumn.AllowIncrementalSearch = false;
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            // 
            // colcosto
            // 
            this.colcosto.Caption = "Costo";
            this.colcosto.DisplayFormat.FormatString = "c";
            this.colcosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            this.colcosto.OptionsColumn.AllowEdit = false;
            this.colcosto.OptionsColumn.AllowFocus = false;
            this.colcosto.OptionsColumn.AllowIncrementalSearch = false;
            this.colcosto.OptionsColumn.AllowMove = false;
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 3;
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
            this.colprecio.OptionsColumn.AllowIncrementalSearch = false;
            this.colprecio.OptionsColumn.AllowMove = false;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            // 
            // colidCategoria
            // 
            this.colidCategoria.Caption = "Categoria";
            this.colidCategoria.ColumnEdit = this.rlupCategoria;
            this.colidCategoria.FieldName = "idCategoria";
            this.colidCategoria.Name = "colidCategoria";
            this.colidCategoria.OptionsColumn.AllowEdit = false;
            this.colidCategoria.OptionsColumn.AllowFocus = false;
            this.colidCategoria.OptionsColumn.AllowIncrementalSearch = false;
            this.colidCategoria.OptionsColumn.AllowMove = false;
            this.colidCategoria.Visible = true;
            this.colidCategoria.VisibleIndex = 5;
            // 
            // colidColor
            // 
            this.colidColor.Caption = "Color";
            this.colidColor.ColumnEdit = this.rlupColor;
            this.colidColor.FieldName = "idColor";
            this.colidColor.Name = "colidColor";
            this.colidColor.OptionsColumn.AllowEdit = false;
            this.colidColor.OptionsColumn.AllowFocus = false;
            this.colidColor.OptionsColumn.AllowIncrementalSearch = false;
            this.colidColor.OptionsColumn.AllowMove = false;
            this.colidColor.Visible = true;
            this.colidColor.VisibleIndex = 6;
            // 
            // colidMarca
            // 
            this.colidMarca.Caption = "Marca";
            this.colidMarca.ColumnEdit = this.rlupMarca;
            this.colidMarca.FieldName = "idMarca";
            this.colidMarca.Name = "colidMarca";
            this.colidMarca.OptionsColumn.AllowEdit = false;
            this.colidMarca.OptionsColumn.AllowFocus = false;
            this.colidMarca.OptionsColumn.AllowIncrementalSearch = false;
            this.colidMarca.OptionsColumn.AllowMove = false;
            this.colidMarca.Visible = true;
            this.colidMarca.VisibleIndex = 7;
            // 
            // colstock
            // 
            this.colstock.Caption = "Stock";
            this.colstock.FieldName = "stock";
            this.colstock.Name = "colstock";
            this.colstock.OptionsColumn.AllowEdit = false;
            this.colstock.OptionsColumn.AllowFocus = false;
            this.colstock.OptionsColumn.AllowIncrementalSearch = false;
            this.colstock.OptionsColumn.AllowMove = false;
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 8;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowEdit = false;
            this.colactivo.OptionsColumn.AllowFocus = false;
            this.colactivo.OptionsColumn.AllowIncrementalSearch = false;
            this.colactivo.OptionsColumn.AllowMove = false;
            // 
            // rlupMarca
            // 
            this.rlupMarca.AutoHeight = false;
            this.rlupMarca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupMarca.DataSource = this.marcaBindingSource;
            this.rlupMarca.DisplayMember = "descripcion";
            this.rlupMarca.Name = "rlupMarca";
            this.rlupMarca.ValueMember = "idMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(CharlsShoes.Entities.Marca);
            // 
            // rlupColor
            // 
            this.rlupColor.AutoHeight = false;
            this.rlupColor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupColor.DataSource = this.colorBindingSource;
            this.rlupColor.DisplayMember = "descripcion";
            this.rlupColor.Name = "rlupColor";
            this.rlupColor.ValueMember = "idColor";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(CharlsShoes.Entities.Color);
            // 
            // rlupCategoria
            // 
            this.rlupCategoria.AutoHeight = false;
            this.rlupCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupCategoria.DataSource = this.categoriaBindingSource;
            this.rlupCategoria.DisplayMember = "descripcion";
            this.rlupCategoria.Name = "rlupCategoria";
            this.rlupCategoria.ValueMember = "idCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(CharlsShoes.Entities.Categoria);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmProductos.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnImprimirRemision;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colidCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colidColor;
        private DevExpress.XtraGrid.Columns.GridColumn colidMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupColor;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}
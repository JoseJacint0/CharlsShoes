
namespace CharlsShoes.Win
{
    partial class frmNMProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNMProducto));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecio = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.lblCosto = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lupCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.lupMarca = new DevExpress.XtraEditors.LookUpEdit();
            this.lupColor = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoria = new DevExpress.XtraEditors.LabelControl();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(255, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(410, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(336, 97);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(149, 20);
            this.txtStock.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(299, 100);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(30, 13);
            this.lblStock.TabIndex = 41;
            this.lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(78, 126);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(32, 133);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(33, 13);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(78, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(165, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(28, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 39;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(78, 93);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(165, 20);
            this.txtCosto.TabIndex = 3;
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(33, 100);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(32, 13);
            this.lblCosto.TabIndex = 38;
            this.lblCosto.Text = "Costo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(78, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Mask.EditMask = "([z-zA-Z] ?)+";
            this.txtDescripcion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(7, 68);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(78, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(50, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID:";
            // 
            // lupCategoria
            // 
            this.lupCategoria.Location = new System.Drawing.Point(336, 5);
            this.lupCategoria.Name = "lupCategoria";
            this.lupCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 67, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Categorias", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupCategoria.Properties.DataSource = this.categoriaBindingSource;
            this.lupCategoria.Properties.DisplayMember = "descripcion";
            this.lupCategoria.Properties.NullText = "";
            this.lupCategoria.Properties.ShowFooter = false;
            this.lupCategoria.Properties.ShowHeader = false;
            this.lupCategoria.Properties.ValueMember = "idCategoria";
            this.lupCategoria.Size = new System.Drawing.Size(149, 20);
            this.lupCategoria.TabIndex = 5;
            // 
            // lupMarca
            // 
            this.lupMarca.Location = new System.Drawing.Point(336, 69);
            this.lupMarca.Name = "lupMarca";
            this.lupMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupMarca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Marcas", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupMarca.Properties.DataSource = this.marcaBindingSource;
            this.lupMarca.Properties.DisplayMember = "descripcion";
            this.lupMarca.Properties.NullText = "";
            this.lupMarca.Properties.ShowFooter = false;
            this.lupMarca.Properties.ShowHeader = false;
            this.lupMarca.Properties.ValueMember = "idMarca";
            this.lupMarca.Size = new System.Drawing.Size(149, 20);
            this.lupMarca.TabIndex = 7;
            // 
            // lupColor
            // 
            this.lupColor.Location = new System.Drawing.Point(335, 35);
            this.lupColor.Name = "lupColor";
            this.lupColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idColor", "id Color", 45, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Colores", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupColor.Properties.DataSource = this.colorBindingSource;
            this.lupColor.Properties.DisplayMember = "descripcion";
            this.lupColor.Properties.NullText = "";
            this.lupColor.Properties.ShowFooter = false;
            this.lupColor.Properties.ShowHeader = false;
            this.lupColor.Properties.ValueMember = "idColor";
            this.lupColor.Size = new System.Drawing.Size(150, 20);
            this.lupColor.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(296, 72);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(33, 13);
            this.lblMarca.TabIndex = 45;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(300, 42);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 13);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "Color:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(279, 8);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(51, 13);
            this.lblCategoria.TabIndex = 47;
            this.lblCategoria.Text = "Categoria:";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(CharlsShoes.Entities.Categoria);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(CharlsShoes.Entities.Color);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(CharlsShoes.Entities.Marca);
            // 
            // frmNMProducto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(513, 206);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lupColor);
            this.Controls.Add(this.lupMarca);
            this.Controls.Add(this.lupCategoria);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNMProducto.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMProducto";
            this.Load += new System.EventHandler(this.frmNMProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.LabelControl lblPrecio;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.LabelControl lblCosto;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LookUpEdit lupCategoria;
        private DevExpress.XtraEditors.LookUpEdit lupMarca;
        private DevExpress.XtraEditors.LookUpEdit lupColor;
        private DevExpress.XtraEditors.LabelControl lblMarca;
        private DevExpress.XtraEditors.LabelControl lblColor;
        private DevExpress.XtraEditors.LabelControl lblCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
    }
}
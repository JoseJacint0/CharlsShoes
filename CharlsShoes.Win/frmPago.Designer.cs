
namespace CharlsShoes.Win
{
    partial class frmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPago));
            this.gControl = new DevExpress.XtraEditors.GroupControl();
            this.txtCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtPago = new DevExpress.XtraEditors.TextEdit();
            this.txtTotPag = new DevExpress.XtraEditors.TextEdit();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistrarVenta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            this.gControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPag.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gControl
            // 
            this.gControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl.Controls.Add(this.txtCambio);
            this.gControl.Controls.Add(this.txtPago);
            this.gControl.Controls.Add(this.txtTotPag);
            this.gControl.Controls.Add(this.lblCambio);
            this.gControl.Controls.Add(this.lblPago);
            this.gControl.Controls.Add(this.lblTotal);
            this.gControl.Location = new System.Drawing.Point(12, 12);
            this.gControl.Name = "gControl";
            this.gControl.Size = new System.Drawing.Size(274, 100);
            this.gControl.TabIndex = 0;
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(102, 65);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(169, 20);
            this.txtCambio.TabIndex = 5;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(102, 39);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(169, 20);
            this.txtPago.TabIndex = 4;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtTotPag
            // 
            this.txtTotPag.Enabled = false;
            this.txtTotPag.Location = new System.Drawing.Point(102, 13);
            this.txtTotPag.Name = "txtTotPag";
            this.txtTotPag.Size = new System.Drawing.Size(169, 20);
            this.txtTotPag.TabIndex = 3;
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Location = new System.Drawing.Point(3, 68);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(71, 16);
            this.lblCambio.TabIndex = 2;
            this.lblCambio.Text = "Su Cambio:";
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.Location = new System.Drawing.Point(4, 40);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(57, 16);
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "Su Pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(4, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Appearance.Options.UseFont = true;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(166, 118);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(120, 23);
            this.btnRegistrarVenta.TabIndex = 2;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // frmPago
            // 
            this.AcceptButton = this.btnRegistrarVenta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(298, 152);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmPago.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            this.gControl.ResumeLayout(false);
            this.gControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPag.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gControl;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnRegistrarVenta;
        private DevExpress.XtraEditors.TextEdit txtCambio;
        private DevExpress.XtraEditors.TextEdit txtPago;
        private DevExpress.XtraEditors.TextEdit txtTotPag;
    }
}
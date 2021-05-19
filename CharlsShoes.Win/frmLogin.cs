using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance(); 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            loopUsuario.EditValue = 1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Misc.usuario = usuarioOperations.Login(new Usuario
                {
                    usuario = loopUsuario.Text,
                    password = txtContraseña.Text
                });
                //SplashScreenManager.CloseDefaultWaitForm();
                Misc.actualiza = true;

                if (Misc.usuario != null)
                {
                    XtraMessageBox.Show("Acceso correcto", "Charls Shoes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("Credenciales incorrectas!", "Charls Shoes", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtContraseña.SelectAll();
                    txtContraseña.Focus();
                }
            }
        }

        private bool validar()
        {
            var ban = false;
            if (loopUsuario.EditValue == null || loopUsuario.Text.Equals(""))
            {
                loopUsuario.ErrorText = "Selecciona un Usuario";
                loopUsuario.Focus();
                ban = true;
            }
            if (txtContraseña.EditValue == null || txtContraseña.Text.Equals(""))
            {
                txtContraseña.ErrorText = "Ingresa una contraseña";
                if(ban == false)
                {
                    txtContraseña.Focus();
                    ban = true;
                }
            }

            if (ban == true)
                return false;
            else
                return true;
        }

        private void loopUsuario_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit).Width;
        }

        private void loopUsuario_EditValueChanged(object sender, EventArgs e)
        {
            txtContraseña.EditValue = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Deseas cerrar esta pantalla?", "Charls Shoes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
}
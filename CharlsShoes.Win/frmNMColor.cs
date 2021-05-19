using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    public partial class frmNMColor : DevExpress.XtraEditors.XtraForm
    {
        private ColorOperations colorOperations = ColorOperations.Instance();
        private Color color;
        //cuando es nuevo color
        public frmNMColor()
        {
            InitializeComponent();
        }

        //cuando es modificar el color
        public frmNMColor(int idColor)
        {
            InitializeComponent();
            color = colorOperations.GetById(idColor);

            txtID.Text = color.idColor.ToString();
            txtDescripcion.Text = color.descripcion;

        }

        private void frmNMColor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (color == null)
                {
                    if (colorOperations.Add(new Color
                    {
                        descripcion = txtDescripcion.Text
                    }) > 0)
                    {
                        XtraMessageBox.Show("Color insertado correctamente", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la inserción", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    color.descripcion = txtDescripcion.Text;

                    if (colorOperations.Update(color) > 0)
                    {
                        XtraMessageBox.Show("Color modificado correctamente", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la modificación", "Charls Shoes", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa una descripción";
                txtDescripcion.Focus();
                ban = true;
            }

            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
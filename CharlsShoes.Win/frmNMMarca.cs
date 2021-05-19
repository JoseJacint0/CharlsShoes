using CharlsShoes.BLL;
using CharlsShoes.Entities;
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
    public partial class frmNMMarca : DevExpress.XtraEditors.XtraForm
    {
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private Marca marca;
        //cuando es nueva marca
        public frmNMMarca()
        {
            InitializeComponent();
        }

        //cuando es modificar la marca
        public frmNMMarca(int idMarca)
        {
            InitializeComponent();
            marca = marcaOperations.GetById(idMarca);

            txtID.Text = marca.idMarca.ToString();
            txtDescripcion.Text = marca.descripcion;

        }

        private void frmNMMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (marca == null)
                {
                    if (marcaOperations.Add(new Marca
                    {
                        descripcion = txtDescripcion.Text
                    }) > 0)
                    {
                        XtraMessageBox.Show("Marca insertada correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
                    marca.descripcion = txtDescripcion.Text;

                    if (marcaOperations.Update(marca) > 0)
                    {
                        XtraMessageBox.Show("Marca modificada correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
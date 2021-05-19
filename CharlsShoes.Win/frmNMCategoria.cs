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
    public partial class frmNMCategoria : DevExpress.XtraEditors.XtraForm
    {
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        private Categoria categoria;
        //cuando es nueva categoria
        public frmNMCategoria()
        {
            InitializeComponent();
        }

        //cuando es modificar la categoria
        public frmNMCategoria(int idCategoria)
        {
            InitializeComponent();
            categoria = categoriaOperations.GetById(idCategoria);
            
            txtID.Text = categoria.idCategoria.ToString();
            txtDescripcion.Text = categoria.descripcion;
            
        }

        private void frmNMCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (categoria == null)
                {
                    if (categoriaOperations.Add(new Categoria
                    {
                        descripcion = txtDescripcion.Text
                    }) > 0)
                    {
                        XtraMessageBox.Show("Categoria insertada correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
                    categoria.descripcion = txtDescripcion.Text;
                    
                    if (categoriaOperations.Update(categoria) > 0)
                    {
                        XtraMessageBox.Show("Categoria modificada correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
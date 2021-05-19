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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private Cliente cliente;
        //cuando es nuevo cliente
        public frmNMCliente()
        {
            InitializeComponent();
        }

        //cuando es modificar el cliente
        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = clienteOperations.GetById(idCliente);

            txtID.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
            txtApellidoP.Text = cliente.apellidoP;
            txtApellidoM.Text = cliente.apellidoM;
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();

        }


        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    if (clienteOperations.Add(new Cliente
                    {
                        nombre = txtNombre.Text,
                        apellidoP = txtApellidoP.Text,
                        apellidoM = txtApellidoM.Text,
                        direccion = txtDireccion.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.EditValue)
                    }) > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
                    cliente.nombre = txtNombre.Text;
                    cliente.apellidoP = txtApellidoP.Text;
                    cliente.apellidoM = txtApellidoM.Text;
                    cliente.direccion = txtDireccion.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.EditValue);

                    if (clienteOperations.Update(cliente) > 0)
                    {
                        XtraMessageBox.Show("Cliente modificado correctamente", "Charls Shoes", MessageBoxButtons.OK,
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
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa un nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                txtApellidoP.ErrorText = "Ingresa un apellido paterno";
                if (!ban)
                {
                    txtApellidoP.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                txtApellidoM.ErrorText = "Ingresa un apellido materno";
                if (!ban)
                {
                    txtApellidoM.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                txtDireccion.ErrorText = "Ingresa una dirección";
                if (!ban)
                {
                    txtDireccion.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa un teléfono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa un descuento";
                if (!ban)
                {
                    txtDescuento.Focus();
                    ban = true;
                }
            }


            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Biblioteca.Frm.CRUDUsuario
{
    public partial class FrmUsuarioUpdate : Form
    {
        Usuario usuario;
        private Usuario sesion;
        private bool cerrarFrm = true;
        public FrmUsuarioUpdate(Usuario usuario, Usuario sesion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.sesion = sesion;
            tbDNI.Text = usuario.DNI;
            tbNombre.Text = usuario.Nombre;
            tbApellidos.Text = usuario.Apellidos;
            cbInicioSesion.Checked = usuario.InicioSesion.GetValueOrDefault();
            tbDireccion.Text = usuario.Direccion;
            tbPoblacion.Text = usuario.Poblacion;
            tbCodigoPostal.Text = usuario.CodigoPostal;
            tbProvincia.Text = usuario.Provincia;
            tbTelefono1.Text = usuario.Telefono1;
            tbTelefono2.Text = usuario.Telefono2;
        }
        private string faltanDatosObligatorios()
        {

            Regex formatoCodigoPosta = new Regex("\\d{5}");
            Regex formatoTelefono = new Regex("\\d{9}");

            string datosObligatorios = "";

            if (tbNombre.Text.Equals(""))
            {
                datosObligatorios += "Nombre\n";
            }
            if (tbApellidos.Text.Equals(""))
            {
                datosObligatorios += "Apellidos\n";
            }
            if (tbDireccion.Text.Equals(""))
            {
                datosObligatorios += "Dirección\n";
            }
            if (tbPoblacion.Text.Equals(""))
            {
                datosObligatorios += "Población\n";
            }
            if (tbCodigoPostal.Text.Equals(""))
            {
                datosObligatorios += "Código Postal\n";
            }
            if (tbProvincia.Text.Equals(""))
            {
                datosObligatorios += "Provincia\n";
            }
            if (tbTelefono1.Text.Equals(""))
            {
                datosObligatorios += "Telefono 1\n";
            }
            else if (!formatoTelefono.IsMatch(tbTelefono1.Text))
            {
                datosObligatorios += "Teléfono 1(ERROR DE FORMATO)\n";
            }

            if (!tbTelefono2.Text.Equals(""))
            {
                if (!formatoTelefono.IsMatch(tbTelefono2.Text))
                {
                    datosObligatorios += "Teléfono 2(ERROR DE FORMATO)\n";
                }
            }
            return datosObligatorios;
        }
        private void ButFuncionales_Click(object sender, EventArgs e)
        {

            if (sender == butAceptar)
            {
                cerrarFrm = true;
                string datosObligatorios = faltanDatosObligatorios();

                if (datosObligatorios.Equals(""))
                {
                    Usuario usuario = new Usuario();

                    usuario.DNI = tbDNI.Text;
                    usuario.Nombre = tbNombre.Text;
                    usuario.Apellidos = tbApellidos.Text;
                    usuario.InicioSesion = cbInicioSesion.Checked;
                    usuario.Salt = this.usuario.Salt;
                    usuario.Direccion = tbDireccion.Text;
                    usuario.Poblacion = tbPoblacion.Text;
                    usuario.CodigoPostal = tbCodigoPostal.Text;
                    usuario.Provincia = tbProvincia.Text;
                    usuario.Telefono1 = tbTelefono1.Text;
                    usuario.Telefono2 = tbTelefono2.Text;

                    if (cbInicioSesion.Checked)
                    {
                        if (this.usuario.InicioSesion == false)
                        {
                            FrmNewPasswordUpdate frmNewPasswordUpdate = new FrmNewPasswordUpdate();

                            if (frmNewPasswordUpdate.ShowDialog() == DialogResult.OK)
                            {
                                usuario.Salt = Password.getPassword(usuario.DNI, frmNewPasswordUpdate.Tag.ToString());
                            }
                            else
                            {
                                cbInicioSesion.Checked = false;
                                cerrarFrm = false;
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (this.usuario.InicioSesion == true)
                        {
                            usuario.InicioSesion = false;
                        }
                    }

                    if (usuario.DNI.Equals("12345678Z"))
                    {
                        MessageBox.Show("ERROR. No se puede editar usuario Administrador!!\n", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // ESCRIBIR AQUI DIALOGO DE ALERTA
                    if (this.sesion.DNI.Equals(usuario.DNI)) {
                        this.sesion = usuario;                        
                    }                    

                    AccesoDatos.Logic.LogicaUsuario.getInstance().editarUsuario(usuario);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ERROR. Faltan datos obligatorios!!\n" + datosObligatorios, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (sender == butCancelar)
            {
                this.Close();
            }
        }

        private void FrmUsuarioUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarFrm)
            {
                e.Cancel = true;
            }
        }
    }
}

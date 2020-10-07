using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDUsuario
{
    public partial class FrmUsuarioCreate : Form
    {
        public FrmUsuarioCreate()
        {
            InitializeComponent();
            tbDNI.Focus();
            cbInicioSesion.Checked = true;
        }
        private string faltanDatosObligatorios()
        {

            Regex formatoDni= new Regex("\\d{8}[A-Z]");
            Regex formatoCodigoPosta = new Regex("\\d{5}");
            Regex formatoTelefono = new Regex("\\d{9}");

            string datosObligatorios = "";

            if (tbDNI.Text.Equals("")){
                datosObligatorios += "DNI\n";
            }
            else if (!formatoDni.IsMatch(tbDNI.Text))
            {
                datosObligatorios += "DNI(ERROR DE FORMATO \"12345678A\")\n";
            }
            if (tbNombre.Text.Equals("")){
                datosObligatorios += "Nombre\n";
            }
            if (tbApellidos.Text.Equals(""))
            {
                datosObligatorios += "Apellidos\n";
            }
            if (tbContraseña.Text.Equals("") && cbInicioSesion.Checked == true)
            {
                datosObligatorios += "Contraseña\n";
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
            } else if (!formatoCodigoPosta.IsMatch(tbCodigoPostal.Text)) {
                datosObligatorios += "Código Postal(ERROR DE FORMATO)\n";
            }
            if (tbProvincia.Text.Equals(""))
            {
                datosObligatorios += "Provincia\n";
            }
            if (tbTelefono1.Text.Equals(""))
            {
                datosObligatorios += "Teléfono 1\n";
            }
            else if (!formatoTelefono.IsMatch(tbTelefono1.Text))
            {
                datosObligatorios += "Teléfono 1(ERROR DE FORMATO)\n";
            }
            if (!tbTelefono2.Text.Equals("")) {
                if (!formatoTelefono.IsMatch(tbTelefono2.Text)) {
                    datosObligatorios += "Teléfono 2(ERROR DE FORMATO)\n";
                }
            }
            return datosObligatorios;
        }

        private void ButFuncionales_Click(object sender, EventArgs e)
        {

            if (sender == butAceptar)
            {
                string datosObligatorios = faltanDatosObligatorios();

                if (datosObligatorios.Equals(""))
                {
                    Usuario usuario = new Usuario();

                    usuario.DNI = tbDNI.Text;
                    usuario.Nombre = tbNombre.Text;
                    usuario.Apellidos = tbApellidos.Text;
                    usuario.InicioSesion = cbInicioSesion.Checked;

                    if (cbInicioSesion.Checked)
                    {
                        usuario.Salt = Password.getPassword(tbDNI.Text, tbContraseña.Text);
                    }

                    usuario.Direccion = tbDireccion.Text;
                    usuario.Poblacion = tbPoblacion.Text;
                    usuario.CodigoPostal = tbCodigoPostal.Text;
                    usuario.Provincia = tbProvincia.Text;
                    usuario.Telefono1 = tbTelefono1.Text;
                    usuario.Telefono2 = tbTelefono2.Text;

                    try
                    {
                        AccesoDatos.Logic.LogicaUsuario.getInstance().insertarUsuario(usuario);
                        this.Tag = usuario.DNI;
                        this.DialogResult = DialogResult.OK;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void CbInicioSesion_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbInicioSesion.Checked)
            {
                tbContraseña.BackColor = Color.FromArgb(255, 185, 124);
                tbContraseña.Enabled = true;
            }
            else
            {
                tbContraseña.Enabled = false;
                tbContraseña.BackColor = Color.Gray;
            }
        }
    }
}

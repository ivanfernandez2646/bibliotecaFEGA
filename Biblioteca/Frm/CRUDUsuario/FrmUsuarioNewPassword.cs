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

namespace Biblioteca.Frm.CRUDUsuario
{
    public partial class FrmUsuarioNewPassword : Form
    {
        private Usuario usuario;

        public FrmUsuarioNewPassword(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            tbAntiguaContraseña.Focus();
        }

        private string faltanDatosObligatorios()
        {

            string datosObligatorios = "";

            if (tbAntiguaContraseña.Text.Equals(""))
            {
                datosObligatorios += "Contraseña Antigua\n";
            }
            if (tbNuevaContraseña.Text.Equals(""))
            {
                datosObligatorios += "Contraseña Nueva\n";
            }
            if (tbNuevaContraseña.Text.Equals(""))
            {
                datosObligatorios += "Repita Contraseña\n";
            }
            return datosObligatorios;
        }

        private void ButFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == butAceptar)
            {
                string datosObligatorios = faltanDatosObligatorios();

                if (!datosObligatorios.Equals(""))
                {
                    MessageBox.Show("ERROR. Faltan datos obligatorios!!\n" + datosObligatorios, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string contraseñaBBDD = usuario.Salt;
                string contraseñaAntigua = Password.getPassword(usuario.DNI, tbAntiguaContraseña.Text);

                if (!contraseñaBBDD.Equals(contraseñaAntigua)) {
                    MessageBox.Show("ERROR. La contraseña antigua es erronea", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!tbNuevaContraseña.Text.Equals(tbRepitaContraseña.Text)) {
                    MessageBox.Show("ERROR. Las nuevas contraseñas no coinciden", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                usuario.Salt = Password.getPassword(usuario.DNI, tbNuevaContraseña.Text);
                AccesoDatos.Logic.LogicaUsuario.getInstance().editarUsuario(usuario);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (sender == butCancelar)
            {
                this.Close();
            }
        }
    }
}

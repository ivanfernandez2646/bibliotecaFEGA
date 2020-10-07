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
    public partial class FrmNewPasswordUpdate : Form
    {
        bool cerrarFrm = false;

        public FrmNewPasswordUpdate()
        {
            InitializeComponent();
        }

        private void ButAceptar_Click(object sender, EventArgs e)
        {
            if (tbNuevaContraseña.Text.Equals("") || tbRepitaContraseña.Text.Equals(""))
            {
                MessageBox.Show("Error. Faltan datos obligatorios!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!tbNuevaContraseña.Text.Equals(tbRepitaContraseña.Text))
            {
                MessageBox.Show("Error. Las contraseñas no coinciden!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Tag = tbNuevaContraseña.Text;
                this.DialogResult = DialogResult.OK;
                cerrarFrm = true;
                this.Close();
            }
        }

        private void FrmNewPasswordUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarFrm)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

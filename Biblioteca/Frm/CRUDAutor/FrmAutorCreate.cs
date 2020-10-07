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

namespace Biblioteca.Frm.CRUDAutor
{
    public partial class FrmAutorCreate : Form
    {
        public FrmAutorCreate()
        {
            InitializeComponent();
            tbNombre.Focus();
        }

        private string faltanDatosObligatorios()
        {

            string datosObligatorios = "";

            if (tbNombre.Text.Equals(""))
            {
                datosObligatorios += "Nombre\n";
            }

            if (tbApellidos.Text.Equals(""))
            {
                datosObligatorios += "Apellidos\n";
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
                    Autor autor = new Autor();
                    autor.Nombre = tbNombre.Text;
                    autor.Apellidos = tbApellidos.Text;

                    AccesoDatos.Logic.LogicaAutor.getInstance().insertarAutor(autor);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ERROR. Faltan datos obligatorios!!\n" + datosObligatorios, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LabSeparador_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmAutorUpdate : Form
    {
        private Autor autor;


        public FrmAutorUpdate(Autor autor)
        {
            InitializeComponent();
            this.autor = autor;
            this.tbNombre.Text = autor.Nombre;
            this.tbApellidos.Text = autor.Apellidos;
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
                    autor.Nombre = tbNombre.Text.ToString();
                    autor.Apellidos = tbApellidos.Text.ToString();

                    AccesoDatos.Logic.LogicaAutor.getInstance().editarAutor(autor);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ERROR. Faltan datos obligatorios!!\n" + datosObligatorios, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

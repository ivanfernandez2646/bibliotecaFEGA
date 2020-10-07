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

namespace Biblioteca.Frm.CRUDGenero
{
    public partial class FrmGeneroUpdate : Form
    {
        private Genero genero;

        public FrmGeneroUpdate(Genero genero)
        {
            InitializeComponent();
            this.genero = genero;
            this.rtbGenero.Text = genero.Descripcion;
            rtbGenero.Focus();
        }

        private string faltanDatosObligatorios()
        {

            string datosObligatorios = "";

            if (rtbGenero.Text.Equals(""))
            {
                datosObligatorios += "Descripción\n";
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
                    genero.Descripcion = rtbGenero.Text.ToString();
                    AccesoDatos.Logic.LogicaGenero.getInstance().editarGenero(genero);
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

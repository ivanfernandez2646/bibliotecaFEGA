using AccesoDatos.Model;
using System;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDGenero
{
    public partial class FrmGeneroCreate : Form
    {
        public FrmGeneroCreate()
        {
            InitializeComponent();
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
                    Genero genero = new Genero();
                    genero.Descripcion = rtbGenero.Text;

                    AccesoDatos.Logic.LogicaGenero.getInstance().insertarGenero(genero);
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
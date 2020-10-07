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

namespace Biblioteca.Frm.CRUDClasificacion
{
    public partial class FrmClasificacionCreate : Form
    {
        public FrmClasificacionCreate()
        {
            InitializeComponent();
            rtbDescripcion.Focus();
        }

        private string faltanDatosObligatorios()
        {

            string datosObligatorios = "";

            if (rtbDescripcion.Text.Equals(""))
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
                    Clasificacion clasificacion = new Clasificacion();
                    clasificacion.Descripcion = rtbDescripcion.Text;

                    AccesoDatos.Logic.LogicaClasificacion.getInstance().insertarClasificacion(clasificacion);
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
    }
}

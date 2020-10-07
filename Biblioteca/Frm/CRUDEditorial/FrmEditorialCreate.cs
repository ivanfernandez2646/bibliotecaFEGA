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

namespace Biblioteca.Frm.CRUDEditorial
{
    public partial class FrmEditorialCreate : Form
    {
        public FrmEditorialCreate()
        {
            InitializeComponent();
            tbRazonSocial.Focus();
        }
        private string faltanDatosObligatorios()
        {

            Regex formatoCodigoPostal = new Regex("\\d{5}");
            Regex formatoTelefono = new Regex("\\d{9}");

            string datosObligatorios = "";

            if (tbRazonSocial.Text.Equals(""))
            {
                datosObligatorios += "Razón Social\n";
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
            } else if (!formatoCodigoPostal.IsMatch(tbCodigoPostal.Text)) {

                datosObligatorios += "Código Postal(ERROR DE FORMATO)\n";
            }

            if (tbProvincia.Text.Equals(""))
            {
                datosObligatorios += "Provincia\n";
            }

            if (tbTelefono1.Text.Equals(""))
            {
                datosObligatorios += "Teléfono 1\n";
            }else if (!formatoTelefono.IsMatch(tbTelefono1.Text))
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
                string datosObligatorios = faltanDatosObligatorios();

                if (datosObligatorios.Equals(""))
                {
                    Editorial editorial = new Editorial();

                    editorial.RazonSocial = tbRazonSocial.Text;
                    editorial.Direccion = tbDireccion.Text;
                    editorial.Poblacion = tbPoblacion.Text;
                    editorial.CodigoPostal = tbCodigoPostal.Text;
                    editorial.Provincia = tbProvincia.Text;
                    editorial.Telefono1 = tbTelefono1.Text;
                    editorial.Telefono2 = tbTelefono2.Text;
                    editorial.PersonaContacto = tbPersonaContacto.Text;
                    editorial.Observaciones = tbObservaciones.Text;

                    AccesoDatos.Logic.LogicaEditorial.getInstance().insertarEditorial(editorial);
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

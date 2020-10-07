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
    public partial class FrmEditorialUpdate : Form
    {
        Editorial editorial;

        public FrmEditorialUpdate(Editorial editorial)
        {
            InitializeComponent();
            this.editorial = editorial;
            tbRazonSocial.Text = editorial.RazonSocial;
            tbDireccion.Text = editorial.Direccion;
            tbPoblacion.Text = editorial.Poblacion;
            tbCodigoPostal.Text = editorial.CodigoPostal;
            tbProvincia.Text = editorial.Provincia;
            tbTelefono1.Text = editorial.Telefono1;
            tbTelefono2.Text = editorial.Telefono2;
            tbRazonSocial.Focus();
        }
        private string faltanDatosObligatorios()
        {
            Regex formatoCodigoPosta = new Regex("\\d{5}");
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

                    this.editorial.RazonSocial = tbRazonSocial.Text;
                    this.editorial.Direccion = tbDireccion.Text;
                    this.editorial.Poblacion = tbPoblacion.Text;
                    this.editorial.CodigoPostal = tbCodigoPostal.Text;
                    this.editorial.Provincia = tbProvincia.Text;
                    this.editorial.Telefono1 = tbTelefono1.Text;
                    this.editorial.Telefono2 = tbTelefono2.Text;
                    this.editorial.PersonaContacto = tbPersonaContacto.Text;
                    this.editorial.Observaciones = tbObservaciones.Text;

                    AccesoDatos.Logic.LogicaEditorial.getInstance().editarEditorial(editorial);
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

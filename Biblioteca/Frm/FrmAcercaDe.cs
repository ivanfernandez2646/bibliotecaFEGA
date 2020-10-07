using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        //Cerramos el formulario al hacer click en el botón aceptar
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

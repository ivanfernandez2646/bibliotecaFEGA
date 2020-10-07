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
    public partial class FrmConfiguracionUpdate : Form
    {
        private AccesoDatos.Model.Configuracion config;

        public FrmConfiguracionUpdate()
        {
            InitializeComponent();
            config = AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion();
            cargarDatos();
            spNumDiasPrestamo1.Focus();
        }

        private void ButAceptar_Click(object sender, EventArgs e)
        {
            config.NumDiasPrestamo1 = (int)spNumDiasPrestamo1.Value;
            config.NumDiasPrestamo2 = (int)spNumDiasPrestamo2.Value;
            config.MaxPrestamoUsuario = (int)spMaxPrestamoUsuario.Value;

            AccesoDatos.Logic.LogicaConfiguracion.getInstance().editarConfiguracion(config);
        }

        private void cargarDatos()
        {
               spNumDiasPrestamo1.Value = (decimal)config.NumDiasPrestamo1;
               spNumDiasPrestamo2.Value = (decimal)config.NumDiasPrestamo2;
               spMaxPrestamoUsuario.Value = (decimal)config.MaxPrestamoUsuario;
        }
    }
}

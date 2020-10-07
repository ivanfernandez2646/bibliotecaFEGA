using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDPrestamo
{
    public partial class FrmPrestamoHistoricoRead : Form, RefreshTables
    {
        public FrmPrestamoHistoricoRead()
        {
            InitializeComponent();
        }

        public struct NewPrestamo
        {
            public int id { get; set; }
            public String nombreApellidos { get; set; }
            public String libro { get; set; }
            public DateTime fechaInicio { get; set; }
            public DateTime fechaFin { get; set; }
            public String fechaDevolucion { get; set; }
        }

        private void refrescarTabla()
        {
            refreshAllTables();
        }

        public void refreshAllTables()
        {
            List<NewPrestamo> prestamosFiltradosTabla = new List<NewPrestamo>();
            //dgvClasificacion.DataSource

            AccesoDatos.Logic.LogicaPrestamo.getInstance().listadoPrestamos()
            .ForEach((prestamo) =>
            {

                if (prestamo.FechaDevolucion != null)
                {

                    prestamosFiltradosTabla.Add(new NewPrestamo
                    {
                        id = prestamo.PrestamoId,
                        nombreApellidos = prestamo.Usuario.Nombre + " " + prestamo.Usuario.Apellidos,
                        libro = prestamo.Libro.Titulo,
                        fechaInicio = prestamo.FechaInicio,
                        fechaFin = prestamo.FechaFin,
                        fechaDevolucion = prestamo.FechaDevolucion.GetValueOrDefault().ToShortDateString()
                    });
                }
            });

            if (!tstbFiltro.Text.Equals(""))
            {

                prestamosFiltradosTabla = prestamosFiltradosTabla.Where(x => x.nombreApellidos.Contains(tstbFiltro.Text)).ToList();
            }

            prestamosFiltradosTabla = prestamosFiltradosTabla.OrderBy(x => x.fechaFin).ToList();
            dgvPrestamo.DataSource = prestamosFiltradosTabla;
        }

        private void tstbFiltro_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void FrmPrestamoHistoricoRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}

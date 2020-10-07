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

namespace Biblioteca.Frm.CRUDPrestamo
{
    public partial class FrmPrestamoRead : Form, RefreshTables
    {
        public FrmPrestamoRead()
        {
            InitializeComponent();
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        public struct NewPrestamo
        {
            public int id { get; set; }
            public String nombreApellidos { get; set; }
            public String libro { get; set; }
            public DateTime fechaInicio { get; set; }
            public DateTime fechaFin { get; set; }
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
        
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmPrestamoCreate frmPrestamoCreate = new FrmPrestamoCreate();
                frmPrestamoCreate.ShowDialog();
                refrescarTabla();
            }
            else if (sender == tslDevolverLibro || sender == devolverToolStripMenuItem)
            {
                Int32 selectedRowCount = dgvPrestamo.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount == 1)
                {
                    Prestamo tempPrestamo = new Prestamo();

                    DataGridViewRow row = dgvPrestamo.SelectedRows[0];
                    tempPrestamo.PrestamoId = Int32.Parse(row.Cells["id"].Value.ToString());
                    tempPrestamo = AccesoDatos.Logic.LogicaPrestamo.getInstance().getPrestamo(tempPrestamo);

                    if (DialogResult.Yes == MessageBox.Show("¿Desea devolver el libro seleccionado?", "Delvolver Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        tempPrestamo.FechaDevolucion = DateTime.Now;
                        AccesoDatos.Logic.LogicaPrestamo.getInstance().editarPrestamo(tempPrestamo);

                        Libro tempLibro = new Libro();
                        tempLibro.LibroId = tempPrestamo.LibroLibroId;

                        tempLibro = AccesoDatos.Logic.LogicaLibro.getInstance().getLibro(tempLibro);
                        tempLibro.StockDisponible += 1;
                        AccesoDatos.Logic.LogicaLibro.getInstance().editarLibro(tempLibro);

                        refrescarTabla();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. No hay una fila seleccionada", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (sender == tslAmpliarPrestamo || sender == ampliarToolStripMenuItem)
            {
                Int32 selectedRowCount = dgvPrestamo.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount == 1)
                {
                    Prestamo tempPrestamo = new Prestamo();

                    DataGridViewRow row = dgvPrestamo.SelectedRows[0];
                    tempPrestamo.PrestamoId = Int32.Parse(row.Cells["id"].Value.ToString());
                    tempPrestamo = AccesoDatos.Logic.LogicaPrestamo.getInstance().getPrestamo(tempPrestamo);
                    DateTime tempFechaInicio = tempPrestamo.FechaInicio;
                    DateTime tempFechaFin = tempPrestamo.FechaFin;
                    int numeroDiasPrestamo2 = AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion().NumDiasPrestamo2.GetValueOrDefault();
                    int numeroDiasPrestamo1 = AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion().NumDiasPrestamo1.GetValueOrDefault();

                    if ((tempFechaFin - tempFechaInicio).TotalDays >= numeroDiasPrestamo1 + numeroDiasPrestamo2)
                    {
                        MessageBox.Show("La fecha de este prestamo no se puede aumentar más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    tempFechaFin = tempFechaFin.AddDays(numeroDiasPrestamo2);
                    if (tempFechaFin.DayOfWeek > DayOfWeek.Friday)
                    {
                        switch (tempFechaFin.DayOfWeek)
                        {
                            case DayOfWeek.Saturday:
                                tempFechaFin = tempFechaFin.AddDays(2);
                                break;
                            case DayOfWeek.Sunday:
                                tempFechaFin = tempFechaFin.AddDays(1);
                                break;
                        }
                    }

                    if (DialogResult.Yes == MessageBox.Show("¿Desea Ampliar la fecha de devolución hasta el " + tempFechaFin.ToShortDateString() + "?", "Ampliar Prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        tempPrestamo.FechaFin = tempFechaFin;
                        AccesoDatos.Logic.LogicaPrestamo.getInstance().editarPrestamo(tempPrestamo);
                    }

                    refrescarTabla();
                }
                else
                {
                    MessageBox.Show("ERROR. No hay una fila seleccionada", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (sender == tstbFiltro)
            {
                refrescarTabla();
            }
        }

        public void refreshAllTables()
        {
            List<NewPrestamo> prestamosFiltradosTabla = new List<NewPrestamo>();
            //dgvClasificacion.DataSource

            AccesoDatos.Logic.LogicaPrestamo.getInstance().listadoPrestamos()
            .ForEach((prestamo) =>
            {

                if (prestamo.FechaDevolucion == null)
                {

                    prestamosFiltradosTabla.Add(new NewPrestamo
                    {
                        id = prestamo.PrestamoId,
                        nombreApellidos = prestamo.Usuario.Nombre + " " + prestamo.Usuario.Apellidos,
                        libro = prestamo.Libro.Titulo,
                        fechaInicio = prestamo.FechaInicio,
                        fechaFin = prestamo.FechaFin
                    });
                }
            });

            if (!tstbFiltro.Text.Equals(""))
            {
                prestamosFiltradosTabla = prestamosFiltradosTabla.Where(x => x.nombreApellidos.ToLower().Contains(tstbFiltro.Text.ToLower())).ToList();
            }

            prestamosFiltradosTabla = prestamosFiltradosTabla.OrderBy(x => x.fechaFin).ToList();
            dgvPrestamo.DataSource = prestamosFiltradosTabla;
        }

        private void FrmPrestamoRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void dgvPrestamo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvPrestamo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            Prestamo prestamo = new Prestamo();
            prestamo.PrestamoId = Int32.Parse(dgvPrestamo.Rows[e.RowIndex].Cells["id"].Value.ToString());
            prestamo = AccesoDatos.Logic.LogicaPrestamo.getInstance().getPrestamo(prestamo);

            var dgvCellStyle = new DataGridViewCellStyle();

            dgvCellStyle.BackColor = Color.Green;
            if (prestamo.FechaFin.CompareTo(DateTime.Now) == 0)
                dgvCellStyle.BackColor = Color.Yellow;
            if (prestamo.FechaFin.CompareTo(DateTime.Now) < 0)
                dgvCellStyle.BackColor = Color.Red;
            dgvPrestamo.Rows[e.RowIndex].DefaultCellStyle = dgvCellStyle;
        }
    }
}

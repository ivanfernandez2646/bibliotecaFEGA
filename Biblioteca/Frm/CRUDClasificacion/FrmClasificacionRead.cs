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
    public partial class FrmClasificacionRead : Form, RefreshTables
    {
        public FrmClasificacionRead()
        {
            InitializeComponent();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {


            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmClasificacionCreate frmClasificacionCreate = new FrmClasificacionCreate();

                if (DialogResult.OK == frmClasificacionCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Clasificacion correcta!!", "Insertar Clasificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarClasificacion();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarClasificacion();
            }
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        private void tstbFiltro_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void borrarClasificacion()
        {
            Int32 selectedRowCount = dgvClasificaciones.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar la clasificación seleccionada?", "Baja Clasificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    try
                    {
                        Clasificacion tempClasificacion = new Clasificacion();

                        DataGridViewRow row = dgvClasificaciones.SelectedRows[0];
                        tempClasificacion.ClasificacionId = Int32.Parse(row.Cells["ClasificacionId"].Value.ToString());
                        AccesoDatos.Logic.LogicaClasificacion.getInstance().borrarClasificacion(tempClasificacion);
                        MessageBox.Show("Baja de Clasificacion correcta!!", "Baja Clasificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarClasificacion()
        {
            Int32 selectedRowCount = dgvClasificaciones.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Clasificacion tempClasificacion = new Clasificacion();

                DataGridViewRow row = dgvClasificaciones.SelectedRows[0];
                tempClasificacion.ClasificacionId = Int32.Parse(row.Cells["ClasificacionId"].Value.ToString());
                tempClasificacion = AccesoDatos.Logic.LogicaClasificacion.getInstance().getClasificacion(tempClasificacion);

                FrmClasificacionUpdate frmAutorUpdate = new FrmClasificacionUpdate(tempClasificacion);

                if (DialogResult.OK == frmAutorUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Clasificacion correcta!!", "Editar Clasificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvClasificacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarClasificacion();
        }

        private void DgvClasificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                borrarClasificacion();
            else if (e.KeyCode == Keys.Enter)
                editarClasificacion();
        }

        void RefreshTables.refreshAllTables()
        {
            if (tstbFiltro.Text.Equals(""))
                dgvClasificaciones.DataSource = AccesoDatos.Logic.LogicaClasificacion.getInstance().listadoClasificaciones();
            else
                dgvClasificaciones.DataSource = AccesoDatos.Logic.LogicaClasificacion.getInstance().listadoClasificaciones()
                .Where(clasificacion => clasificacion.Descripcion.ToLower().Contains(tstbFiltro.Text.ToLower())).ToList();
        }

        private void FrmClasificacionRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}

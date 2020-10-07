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
    public partial class FrmGeneroRead : Form, RefreshTables
    {
        public FrmGeneroRead()
        {
            InitializeComponent();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmGeneroCreate frmGeneroCreate = new FrmGeneroCreate();

                if (DialogResult.OK == frmGeneroCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Género correcta!!", "Insertar Género", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarGenero();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarGenero();
            }
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        private void TstbFiltroDescripcion_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void editarGenero()
        {
            Int32 selectedRowCount = dgvGenero.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Genero tempGenero = new Genero();

                DataGridViewRow row = dgvGenero.SelectedRows[0];
                tempGenero.GeneroId = Int32.Parse(row.Cells["GeneroId"].Value.ToString());
                tempGenero = AccesoDatos.Logic.LogicaGenero.getInstance().getGenero(tempGenero);

                FrmGeneroUpdate frmGeneroUpdate = new FrmGeneroUpdate(tempGenero);

                if (DialogResult.OK == frmGeneroUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Género correcta!!", "Editar Género", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void borrarGenero()
        {
            Int32 selectedRowCount = dgvGenero.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar el género seleccionado?", "Baja Género", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    try
                    {
                        Genero tempGenero = new Genero();

                        DataGridViewRow row = dgvGenero.SelectedRows[0];
                        tempGenero.GeneroId = Int32.Parse(row.Cells["GeneroId"].Value.ToString());
                        AccesoDatos.Logic.LogicaGenero.getInstance().borrarGenero(tempGenero);
                        MessageBox.Show("Baja de Género correcta!!", "Baja Género", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja Género", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void DgvGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarGenero();
        }

        private void DgvGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                borrarGenero();
            else if (e.KeyCode == Keys.Enter)
                editarGenero();
        }

        private void FrmGeneroRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        public void refreshAllTables()
        {
            if (tstbFiltroDescripcion.Text.Equals(""))
                dgvGenero.DataSource = AccesoDatos.Logic.LogicaGenero.getInstance().listadoGeneros();
            else
                dgvGenero.DataSource = AccesoDatos.Logic.LogicaGenero.getInstance().listadoGeneros()
                .Where(genero => genero.Descripcion.ToLower().Contains(tstbFiltroDescripcion.Text.ToLower())).ToList();
        }
    }
}

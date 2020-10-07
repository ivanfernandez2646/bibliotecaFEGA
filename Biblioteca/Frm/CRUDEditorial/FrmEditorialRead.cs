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

namespace Biblioteca.Frm.CRUDEditorial
{
    public partial class FrmEditorialRead : Form, RefreshTables
    {
        public FrmEditorialRead()
        {
            InitializeComponent();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmEditorialCreate frmEditorialCreate = new FrmEditorialCreate();

                if (DialogResult.OK == frmEditorialCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Editorial correcta!!", "Insertar Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarEditorial();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarEditorial();
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

        private void borrarEditorial()
        {
            Int32 selectedRowCount = dgvEditorial.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar la editorial seleccionada?", "Baja Editorial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    try
                    {
                        Editorial tempEditorial = new Editorial();

                        DataGridViewRow row = dgvEditorial.SelectedRows[0];
                        tempEditorial.EditorialId = Int32.Parse(row.Cells["EditorialId"].Value.ToString());
                        AccesoDatos.Logic.LogicaEditorial.getInstance().borrarEditorial(tempEditorial);
                        MessageBox.Show("Baja de Editorial correcta!!", "Baja Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja Editorial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarEditorial()
        {
            Int32 selectedRowCount = dgvEditorial.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Editorial tempEditorial = new Editorial();

                DataGridViewRow row = dgvEditorial.SelectedRows[0];
                tempEditorial.EditorialId = Int32.Parse(row.Cells["EditorialId"].Value.ToString());
                tempEditorial = AccesoDatos.Logic.LogicaEditorial.getInstance().getEditorial(tempEditorial);

                FrmEditorialUpdate frmEditorialUpdate = new FrmEditorialUpdate(tempEditorial);

                if (DialogResult.OK == frmEditorialUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Editorial correcta!!", "Editar Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvEditorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarEditorial();
        }

        private void DgvEditorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                borrarEditorial();
            else if (e.KeyCode == Keys.Enter)
                editarEditorial();
        }

        private void FrmEditorialRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        public void refreshAllTables()
        {
            if (tsbRazonSocial.Text.Equals(""))
                dgvEditorial.DataSource = AccesoDatos.Logic.LogicaEditorial.getInstance().listadoEditorial();
            else
                dgvEditorial.DataSource = AccesoDatos.Logic.LogicaEditorial.getInstance().listadoEditorial()
                .Where(editorial => editorial.RazonSocial.ToLower().Contains(tsbRazonSocial.Text.ToLower())).ToList();
        }
    }
}

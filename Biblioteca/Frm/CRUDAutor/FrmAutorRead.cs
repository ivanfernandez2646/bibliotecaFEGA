using AccesoDatos.Model;
using Biblioteca.Frm.CRUDAutor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDAutor
{
    public partial class FrmAutorRead : Form,RefreshTables
    {
        public FrmAutorRead()
        {
            InitializeComponent();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmAutorCreate frmAutorCreate = new FrmAutorCreate();

                if (DialogResult.OK == frmAutorCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Autor correcta!!", "Insertar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarAutor();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarAutor();
            }
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        private void TstbFiltroApellidos_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void borrarAutor()
        {
            Int32 selectedRowCount = dgvAutores.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar el autor seleccionado?", "Baja Autor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    try
                    {
                        Autor tempAutor = new Autor();

                        DataGridViewRow row = dgvAutores.SelectedRows[0];
                        tempAutor.AutorId = Int32.Parse(row.Cells["AutorId"].Value.ToString());
                        AccesoDatos.Logic.LogicaAutor.getInstance().borrarAutor(tempAutor);
                        MessageBox.Show("Baja de Autor correcta!!", "Baja Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarAutor()
        {
            Int32 selectedRowCount = dgvAutores.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Autor tempAutor = new Autor();

                DataGridViewRow row = dgvAutores.SelectedRows[0];
                tempAutor.AutorId = Int32.Parse(row.Cells["AutorId"].Value.ToString());
                tempAutor = AccesoDatos.Logic.LogicaAutor.getInstance().getAutor(tempAutor);

                FrmAutorUpdate frmAutorUpdate = new FrmAutorUpdate(tempAutor);

                if (DialogResult.OK == frmAutorUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Autor correcta!!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarAutor();
        }

        private void DgvAutores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                borrarAutor();
            else if (e.KeyCode == Keys.Enter)
                editarAutor();
        }

        void RefreshTables.refreshAllTables()
        {
            if (tstbFiltroApellidos.Text.Equals(""))
                dgvAutores.DataSource = AccesoDatos.Logic.LogicaAutor.getInstance().listadoAutores();
            else
                dgvAutores.DataSource = AccesoDatos.Logic.LogicaAutor.getInstance().listadoAutores()
                .Where(autor => autor.Apellidos.ToLower().Contains(tstbFiltroApellidos.Text.ToLower())).ToList();
        }

        private void FrmAutorRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}

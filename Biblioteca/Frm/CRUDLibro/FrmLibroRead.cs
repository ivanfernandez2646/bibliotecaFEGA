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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca.Frm.CRUDLibro
{
    public partial class FrmLibroRead : Form, RefreshTables
    {

        private bool primeraCargaComboBoxes = true;
        private List<int> indice = new List<int>();

        public FrmLibroRead()
        {
            InitializeComponent();
            dgvLibro.RowTemplate.Height = 50;
            dgvLibro.Columns[3].Width = 100;
            asignarValoresComboBoxes();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmLibroCreate frmLibroCreate = new FrmLibroCreate();

                if (DialogResult.OK == frmLibroCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Libro correcta!!", "Insertar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refrescarTabla();
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarLibro();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarLibro();
            }else if(sender == tslImagen || sender == imagenToolStripMenuItem)
            {
                abrirImagen();
            }
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        private void TstbFiltroTitulo_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }


        private void editarLibro()
        {
            Int32 selectedRowCount = dgvLibro.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Libro tempLibro = new Libro();

                DataGridViewRow row = dgvLibro.SelectedRows[0];
                tempLibro.LibroId = Int32.Parse(row.Cells["LibroId"].Value.ToString());
                tempLibro = AccesoDatos.Logic.LogicaLibro.getInstance().getLibro(tempLibro);

                FrmLibroUpdate frmLibroUpdate = new FrmLibroUpdate(tempLibro);

                if (DialogResult.OK == frmLibroUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Libro correcta!!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void borrarLibro()
        {
            Int32 selectedRowCount = dgvLibro.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar el libro seleccionado?", "Baja Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    try
                    {
                        Libro tempLibro = new Libro();

                        DataGridViewRow row = dgvLibro.SelectedRows[0];
                        tempLibro.LibroId = Int32.Parse(row.Cells["LibroId"].Value.ToString());
                        AccesoDatos.Logic.LogicaLibro.getInstance().borrarLibro(tempLibro);
                        MessageBox.Show("Baja de Libro correcta!!", "Baja Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvLibro.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                if (dgvLibro.CurrentCell.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    abrirImagen();
                }
                else
                {
                    editarLibro();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void asignarValoresComboBoxes()
        {
            if (!primeraCargaComboBoxes)
            {
                //Recorremos al revés porque si eliminamos índice menores primero da inconsistencia
                indice.Reverse();
                foreach (int i in indice)
                {
                    dgvLibro.Columns.RemoveAt(i);
                }
                indice.Clear();
            }

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.DataSource = AccesoDatos.Logic.LogicaAutor.getInstance().listadoAutores();
            cmb.DisplayMember = "Apellidos";
            cmb.HeaderText = "Autor";
            cmb.DataPropertyName = "AutorAutorId";
            cmb.ValueMember = "AutorId";
            cmb.ReadOnly = true;
            dgvLibro.Columns.Add(cmb);
            indice.Add(cmb.Index);


            DataGridViewComboBoxColumn cmb1 = new DataGridViewComboBoxColumn();
            cmb1.DataSource = AccesoDatos.Logic.LogicaGenero.getInstance().listadoGeneros();
            cmb1.DisplayMember = "Descripcion";
            cmb1.HeaderText = "Genero";
            cmb1.DataPropertyName = "GeneroGeneroId";
            cmb1.ValueMember = "GeneroId";
            cmb1.ReadOnly = true;
            dgvLibro.Columns.Add(cmb1);
            indice.Add(cmb1.Index);


            DataGridViewComboBoxColumn cmb2 = new DataGridViewComboBoxColumn();
            cmb2.DataSource = AccesoDatos.Logic.LogicaClasificacion.getInstance().listadoClasificaciones();
            cmb2.DisplayMember = "Descripcion";
            cmb2.HeaderText = "Clasificacion";
            cmb2.DataPropertyName = "ClasificacionClasificacionId";
            cmb2.ValueMember = "ClasificacionId";
            cmb2.ReadOnly = true;
            dgvLibro.Columns.Add(cmb2);
            indice.Add(cmb2.Index);


            DataGridViewComboBoxColumn cmb3 = new DataGridViewComboBoxColumn();
            cmb3.DataSource = AccesoDatos.Logic.LogicaEditorial.getInstance().listadoEditorial();
            cmb3.DisplayMember = "RazonSocial";
            cmb3.HeaderText = "Editorial";
            cmb3.DataPropertyName = "EditorialEditorialId";
            cmb3.ValueMember = "EditorialId";
            cmb3.ReadOnly = true;
            dgvLibro.Columns.Add(cmb3);
            indice.Add(cmb3.Index);

            primeraCargaComboBoxes = false;
        }

        private void FrmLibroRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        public void refreshAllTables()
        {
            asignarValoresComboBoxes();
            if (tstbFiltroTitulo.Text.Equals(""))
                dgvLibro.DataSource = AccesoDatos.Logic.LogicaLibro.getInstance().listadoLibros();
            else
                dgvLibro.DataSource = AccesoDatos.Logic.LogicaLibro.getInstance().listadoLibros()
                .Where(libro => libro.Titulo.ToLower().Contains(tstbFiltroTitulo.Text.ToLower())).ToList();
            foreach (var column in dgvLibro.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
                }
            }

            for(int i = 0; i < dgvLibro.Rows.Count; i++)
            {
                if(dgvLibro.Rows[i].Cells["Imagen"].Value == null)
                {
                    dgvLibro.Rows[i].Cells["Imagen"].Value = Biblioteca.Properties.Resources.imagenSinFondooBuena;
                    dgvLibro.Rows[i].Cells["Imagen"].Tag = "noImagen";
                }
                else
                {
                    dgvLibro.Rows[i].Cells["Imagen"].Tag = "imagenValida";
                }
            }
        }

        private void abrirImagen()
        {
            Int32 selectedRowCount = dgvLibro.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                byte[] imgByte = (byte[])dgvLibro.CurrentRow.Cells["Imagen"].Value;
                String imgValida = dgvLibro.CurrentRow.Cells["Imagen"].Tag.ToString();


                if (!imgValida.Equals("noImagen"))
                {
                    ImageConverter ic = new ImageConverter();
                    Image imgTmp = (Image)ic.ConvertFrom(imgByte);
                    FrmAbrirFoto frmAbrirFoto = new FrmAbrirFoto(imgTmp);
                    frmAbrirFoto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR. Libro sin imagen", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

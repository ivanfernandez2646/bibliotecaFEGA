using AccesoDatos.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDUsuario
{
    public partial class FrmUsuarioRead : Form, RefreshTables
    {
        public FrmUsuarioRead()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = AccesoDatos.Logic.LogicaUsuario.getInstance().listadoUsuario();
        }

        private void ToolStripLabelsFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == tslAnadir || sender == añadirToolStripMenuItem)
            {
                FrmUsuarioCreate frmUsuarioCreate = new FrmUsuarioCreate();

                if (DialogResult.OK == frmUsuarioCreate.ShowDialog())
                {
                    MessageBox.Show("Alta de Usuario correcta!!", "Insertar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else if (sender == tslEditar || sender == editarToolStripMenuItem)
            {
                editarUsuario();
            }
            else if (sender == tslBorrar || sender == eliminarToolStripMenuItem)
            {
                borrarUsuario();
            }
            else if (sender == tslResetPassword || sender == reiniciarContraseñaToolStripMenuItem)
            {
                Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount == 1)
                {


                    Usuario tempUsuario = new Usuario();

                    DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                    tempUsuario.DNI = row.Cells["DNI"].Value.ToString();
                    tempUsuario = AccesoDatos.Logic.LogicaUsuario.getInstance().getUsuario(tempUsuario);                    

                    bool inicioSesion = tempUsuario.InicioSesion.GetValueOrDefault();
                    if (inicioSesion)
                    {
                        String contraseñaPorDefecto = "123456";
                        tempUsuario.Salt = Password.getPassword(tempUsuario.DNI,contraseñaPorDefecto);
                        AccesoDatos.Logic.LogicaUsuario.getInstance().editarUsuario(tempUsuario);
                        MessageBox.Show("Contraseña Reiniciada a: " + contraseñaPorDefecto, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR. Solo pueden reiniciar contraseña usuarios con inicio de sesion", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. No hay una fila seleccionada", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void refrescarTabla()
        {
            ((FrmPpal)this.MdiParent).refreshAllTables();
        }

        private void TstbFiltroDni_TextChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void editarUsuario()
        {
            Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                Usuario usu = new Usuario();
                usu.DNI = row.Cells["DNI"].Value.ToString();
                usu = AccesoDatos.Logic.LogicaUsuario.getInstance().getUsuario(usu);
                FrmUsuarioUpdate frmUsuarioUpdate = new FrmUsuarioUpdate(usu,((FrmPpal)this.MdiParent).UsuarioIniciado);
                if (DialogResult.OK == frmUsuarioUpdate.ShowDialog())
                {
                    MessageBox.Show("Edición de Usuario correcta!!", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void borrarUsuario()
        {
            Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                Usuario tempUsuario = new Usuario();


                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                tempUsuario.DNI = row.Cells["DNI"].Value.ToString();

                if (tempUsuario.DNI.Equals("12345678Z"))
                {
                    MessageBox.Show("Error. No se puede eliminar el usuario Administrador", "Baja Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult confirmarBorrado = MessageBox.Show("¿Está seguro de que desea borrar el usuario seleccionado?", "Baja Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmarBorrado == DialogResult.Yes)
                    {
                        try
                        {
                            if (tempUsuario.DNI.Equals(((FrmPpal)this.MdiParent).UsuarioIniciado.DNI))
                            {
                                MessageBox.Show("ERROR. No se puede eliminar al usuario con sesion iniciada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            AccesoDatos.Logic.LogicaUsuario.getInstance().borrarUsuario(tempUsuario);
                            MessageBox.Show("Baja de Usuario correcta!! DNI: " + tempUsuario.DNI, "Baja Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refrescarTabla();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Baja Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR. No hay una fila seleccionada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarUsuario();
        }

        private void DgvUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                borrarUsuario();
            else if (e.KeyCode == Keys.Enter)
                editarUsuario();
        }

        private void FrmUsuarioRead_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        public void refreshAllTables()
        {
            if (tstbFiltroApellido.Text.Equals(""))
                dgvUsuarios.DataSource = AccesoDatos.Logic.LogicaUsuario.getInstance().listadoUsuario();
            else
                dgvUsuarios.DataSource = AccesoDatos.Logic.LogicaUsuario.getInstance().listadoUsuario()
                .Where(usuario => usuario.DNI.ToLower().Contains(tslFiltroApellido.Text.ToLower())).ToList();
        }
    }
}

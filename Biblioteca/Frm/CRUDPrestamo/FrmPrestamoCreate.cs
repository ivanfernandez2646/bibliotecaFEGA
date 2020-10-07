using AccesoDatos.Model;
using Biblioteca.Frm.CRUDLibro;
using Biblioteca.Frm.CRUDUsuario;
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
    public partial class FrmPrestamoCreate : Form
    {

        bool prueba = false;

        public FrmPrestamoCreate()
        {
            InitializeComponent();
            cargarComboBox(0);
            anadirFechas();
            prueba = true;
        }

        private String camposObligatorios() {

            StringBuilder stringBuilder = new StringBuilder();

            if (cbLibros.SelectedIndex == -1 || cbLibros.SelectedIndex == 0 || cbLibros.SelectedIndex == 1) {
                stringBuilder.Append("Libro incorrecto\n");
            }
            if (cbUsuarios.SelectedIndex == -1 || cbUsuarios.SelectedIndex == 0 || cbUsuarios.SelectedIndex == 1)
            {
                stringBuilder.Append("Usuario incorrecto\n");
            }

            return stringBuilder.ToString();
        }

        private void cargarComboBox(int num) {
            
            //RecargaLibro
            if(num == 1 || num == 0)
            {
                List<Libro> libros = new List<Libro>();

                Libro l = new Libro();
                l.LibroId = -1;
                l.Titulo = "Seleccione un libro...";
                libros.Add(l);

                l = new Libro();
                l.LibroId = -1;
                l.Titulo = "Crear Libro";
                libros.Add(l);

                libros.AddRange(AccesoDatos.Logic.LogicaLibro.getInstance().listadoLibros().Where(x => x.StockDisponible > 0).ToList());

                cbLibros.DataSource = libros;
                cbLibros.DisplayMember = "Titulo";
            }

            //RecargaUsuario
            if(num == 2 || num == 0)
            {
                List<StructCbUsuario> usuarios = new List<StructCbUsuario>();
                StructCbUsuario u = new StructCbUsuario();
                u.dni = "-1";
                u.nombreCompleto = "Seleccione un usuario...";
                usuarios.Add(u);

                u = new StructCbUsuario();
                u.dni = "-1";
                u.nombreCompleto = "Crear Usuario";
                usuarios.Add(u);

                AccesoDatos.Logic.LogicaUsuario.getInstance().listadoUsuario().ForEach((x) => {
                    int cont = AccesoDatos.Logic.LogicaPrestamo.getInstance().listadoPrestamos().Where(y => y.UsuarioDNI.Equals(x.DNI)).Count();
                    int maximoPrestamosUsuarios = AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion().MaxPrestamoUsuario.GetValueOrDefault();
                    if (maximoPrestamosUsuarios > cont)
                    {
                        usuarios.Add(new StructCbUsuario
                        {
                            dni = x.DNI,
                            nombreCompleto = x.Apellidos + " " + x.Nombre
                        });
                    }
                });

                cbUsuarios.DataSource = usuarios;
                cbUsuarios.DisplayMember = "nombreCompleto";
            }
        }

        private void anadirFechas() {
            tbFechaInicio.Text = DateTime.Now.ToShortDateString();
            DateTime tempFechaFin = DateTime.Now.AddDays(AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion().NumDiasPrestamo1.GetValueOrDefault());
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
            tbFechaFin.Text = tempFechaFin.ToShortDateString();
        }

        public struct StructCbUsuario{
            public string dni { get; set; }
            public string nombreCompleto { get; set; }
        }


        private void butFuncionales_Click(object sender, EventArgs e)
        {

            if (sender == btAceptar)
            {
                String errores = camposObligatorios();
                if (!errores.Equals(""))
                {
                    MessageBox.Show("Error.\n" + errores, "Insertar Préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Prestamo prestamo = new Prestamo();
                prestamo.FechaInicio = DateTime.Parse(tbFechaInicio.Text);
                prestamo.FechaFin = DateTime.Parse(tbFechaFin.Text);
                prestamo.LibroLibroId = ((Libro)cbLibros.SelectedItem).LibroId;
                prestamo.UsuarioDNI = ((StructCbUsuario)cbUsuarios.SelectedItem).dni;
                AccesoDatos.Logic.LogicaPrestamo.getInstance().insertarPrestamo(prestamo);

                Libro tempLibro = new Libro();
                tempLibro.LibroId = prestamo.LibroLibroId;
                Libro libro = AccesoDatos.Logic.LogicaLibro.getInstance().getLibro(tempLibro);
                libro.StockDisponible -= 1;
                AccesoDatos.Logic.LogicaLibro.getInstance().editarLibro(libro);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (sender == btCancelar)
            {
                this.Close();
            }
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prueba)
            {
                if (sender == cbLibros && cbLibros.SelectedIndex == 1)
                {
                    FrmLibroCreate frmLibroCreate = new FrmLibroCreate();

                    if (DialogResult.OK == frmLibroCreate.ShowDialog())
                    {
                        MessageBox.Show("Alta de Libro correcta!!", "Insertar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBox(1);
                        cbLibros.SelectedItem = cbLibros.Items[cbLibros.Items.Count - 1];
                    }
                    else
                    {
                        cbLibros.SelectedItem = cbLibros.Items[0];
                    }
                }
                else if (sender == cbUsuarios && cbUsuarios.SelectedIndex == 1)
                {
                    FrmUsuarioCreate frmUsuarioCreate = new FrmUsuarioCreate();

                    if (DialogResult.OK == frmUsuarioCreate.ShowDialog())
                    {
                        String dniUsuarioCreado = frmUsuarioCreate.Tag.ToString();
                        MessageBox.Show("Alta de Usuario correcta!!", "Insertar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBox(2);

                        List<StructCbUsuario> usuarios = (List<StructCbUsuario>)cbUsuarios.DataSource;

                        int cont = 0;
                        foreach(StructCbUsuario u in usuarios)
                        {
                            if (u.dni.Equals(dniUsuarioCreado))
                            {
                                cbUsuarios.SelectedItem = cbUsuarios.Items[cont];
                                break;
                            }
                            cont++;
                        }
                    }
                    else
                    {
                        cbUsuarios.SelectedItem = cbUsuarios.Items[0];
                    }
                }
            }
        }

        private void ComboBoxes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (sender == cbLibros)
            {
                Libro n = (Libro)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);

                    e.Graphics.DrawString(n.Titulo, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    e.DrawBackground();

                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular);

                    e.Graphics.DrawString(n.Titulo, f,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
            else if (sender == cbUsuarios)
            {
                StructCbUsuario n = (StructCbUsuario)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);

                    e.Graphics.DrawString(n.nombreCompleto, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular);

                    e.DrawBackground();
                    e.Graphics.DrawString(n.nombreCompleto, f,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
        }
    }
}

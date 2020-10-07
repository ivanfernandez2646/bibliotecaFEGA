using AccesoDatos.Model;
using Biblioteca.Frm.CRUDAutor;
using Biblioteca.Frm.CRUDClasificacion;
using Biblioteca.Frm.CRUDEditorial;
using Biblioteca.Frm.CRUDGenero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm.CRUDLibro
{
    public partial class FrmLibroUpdate : Form
    {
        private bool imagenCambiada = false;
        private Libro libro;
        bool prueba = false;

        bool[] seleccionados = new bool[] { false, false, false, false };

        public FrmLibroUpdate(Libro libro)
        {
            InitializeComponent();
            this.libro = libro;
            this.tbTitulo.Text = libro.Titulo;
            this.tbDescripcion.Text = libro.Descripción;

            if(libro.Stock != null)
            {
                this.tbStock.Text = libro.Stock.ToString();
            }

            if(libro.StockDisponible != null)
            {
                this.tbStockDisponible.Text = libro.StockDisponible.ToString();
            }

            if (libro.Imagen != null)
            {
                this.pbImagenLibro.Image = (Bitmap)((new ImageConverter()).ConvertFrom(libro.Imagen));
            }
            cargarComboBoxes(0);
            tbTitulo.Focus();
            prueba = true;
        }

        private string faltanDatosObligatorios()
        {

            string datosObligatorios = "";

            if (tbTitulo.Text.Equals(""))
            {
                datosObligatorios += "Título\n";
            }

            if (tbDescripcion.Text.Equals(""))
            {
                datosObligatorios += "Descripción\n";
            }

            if (cbAutor.SelectedItem == null || cbAutor.SelectedIndex == 0 || cbAutor.SelectedIndex == 1)
            {
                datosObligatorios += "Autor incorrecto\n";
            }

            if (cbClasificacion.SelectedItem == null || cbClasificacion.SelectedIndex == 0 || cbClasificacion.SelectedIndex == 1)
            {
                datosObligatorios += "Clasificación incorrecta\n";
            }

            if (cbGenero.SelectedItem == null || cbGenero.SelectedIndex == 0 || cbGenero.SelectedIndex == 1)
            {
                datosObligatorios += "Género incorrecto\n";
            }

            if (cbEditorial.SelectedItem == null || cbEditorial.SelectedIndex == 0 || cbEditorial.SelectedIndex == 1)
            {
                datosObligatorios += "Editorial incorrecta\n";
            }
            return datosObligatorios;
        }

        private void ButFuncionales_Click(object sender, EventArgs e)
        {

            if (sender == butAceptar)
            {
                string datosObligatorios = faltanDatosObligatorios();

                if (datosObligatorios.Equals(""))
                {
                    libro.Titulo = tbTitulo.Text;
                    libro.LibroId = this.libro.LibroId;
                    libro.Descripción = tbDescripcion.Text;
                    libro.AutorAutorId = ((NewAutor)cbAutor.SelectedItem).AutorId;
                    libro.ClasificacionClasificacionId = ((Clasificacion)cbClasificacion.SelectedItem).ClasificacionId;
                    libro.EditorialEditorialId = ((NewEditorial)cbEditorial.SelectedItem).EditorialId;
                    libro.GeneroGeneroId = ((Genero)cbGenero.SelectedItem).GeneroId;

                    if (imagenCambiada)
                    {
                        libro.Imagen = File.ReadAllBytes(pbImagenLibro.Tag.ToString());
                    }

                    AccesoDatos.Logic.LogicaLibro.getInstance().editarLibro(libro);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ERROR. Faltan datos obligatorios!!\n" + datosObligatorios, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (sender == butCancelar)
            {
                this.Close();
            }
        }

        private void PbImagenLibro_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                pbImagenLibro.Image = Image.FromFile(openFileDialog.FileName);
                pbImagenLibro.Tag = openFileDialog.FileName;
                imagenCambiada = true;
            }
        }

        private void PbImagenLibro_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void PbImagenLibro_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cargarComboBoxes(int num)
        {
            //Recarga Autores
            if (num == 1 || num == 0)
            {
                //Engañamos al programa creando un falso NewAutor crear usuario
                List<NewAutor> newAutors = new List<NewAutor>();

                NewAutor a = new NewAutor();
                a.NombreCompleto = "Seleccione un autor...";
                a.AutorId = -1;
                newAutors.Add(a);

                a.NombreCompleto = "Crear Autor";
                a.AutorId = -1;
                newAutors.Add(a);

                newAutors.AddRange(AccesoDatos.Logic.LogicaAutor.getInstance().listadoAutores().Select(
                    x => new NewAutor
                    {
                        NombreCompleto = x.Apellidos + ", " + x.Nombre,
                        AutorId = x.AutorId
                    }).ToList());

                cbAutor.DataSource = newAutors;
                cbAutor.DisplayMember = "NombreCompleto";

                var autSel = newAutors.Where(aut => aut.AutorId == libro.AutorAutorId).FirstOrDefault();
                cbAutor.SelectedItem = autSel;
            }

            if (num == 2 || num == 0)
            {
                //Recarga Editoriales
                List<NewEditorial> newEditorials = new List<NewEditorial>();

                NewEditorial e = new NewEditorial();
                e.RazonSocialCp = "Seleccione una editorial...";
                e.EditorialId = -1;
                newEditorials.Add(e);

                e.RazonSocialCp = "Crear Editorial";
                e.EditorialId = -1;
                newEditorials.Add(e);

                newEditorials.AddRange(AccesoDatos.Logic.LogicaEditorial.getInstance().listadoEditorial().Select(
                    x => new NewEditorial
                    {
                        RazonSocialCp = x.RazonSocial + ", " + x.CodigoPostal,
                        EditorialId = x.EditorialId
                    }).ToList());
                cbEditorial.DataSource = newEditorials;
                cbEditorial.DisplayMember = "RazonSocialCp";

                var edSel = newEditorials.Where(ed => ed.EditorialId == libro.EditorialEditorialId).FirstOrDefault();
                cbEditorial.SelectedItem = edSel;
            }

            if (num == 3 || num == 0)
            {
                //Recarga Clasificaciones
                List<Clasificacion> clasificaciones = new List<Clasificacion>();

                Clasificacion c = new Clasificacion();
                c.Descripcion = "Seleccione una clasificación...";
                c.ClasificacionId = -1;
                clasificaciones.Add(c);

                c = new Clasificacion();
                c.Descripcion = "Crear Clasificación";
                c.ClasificacionId = -1;
                clasificaciones.Add(c);

                clasificaciones.AddRange(AccesoDatos.Logic.LogicaClasificacion.getInstance().listadoClasificaciones());
                cbClasificacion.DataSource = clasificaciones;
                cbClasificacion.DisplayMember = "Descripcion";

                var clSel = clasificaciones.Where(cl => cl.ClasificacionId == libro.ClasificacionClasificacionId).FirstOrDefault();
                cbClasificacion.SelectedItem = clSel;
            }

            if (num == 4 || num == 0)
            {
                //Recarga Géneros
                List<Genero> generos = new List<Genero>();

                Genero g = new Genero();
                g.GeneroId = -1;
                g.Descripcion = "Seleccione un género...";
                generos.Add(g);

                g = new Genero();
                g.GeneroId = -1;
                g.Descripcion = "Crear Género";
                generos.Add(g);
                generos.AddRange(AccesoDatos.Logic.LogicaGenero.getInstance().listadoGeneros());
                cbGenero.DataSource = generos;
                cbGenero.DisplayMember = "Descripcion";

                var geSel = generos.Where(ge => ge.GeneroId == libro.GeneroGeneroId).FirstOrDefault();
                cbGenero.SelectedItem = geSel;
            }
        }

        private void ButBorrarImagen_Click(object sender, EventArgs e)
        {
            pbImagenLibro.Image = Biblioteca.Properties.Resources.iconImagen;
            imagenCambiada = false;
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prueba)
            {
                if (sender == cbAutor && cbAutor.SelectedIndex == 1)
                {
                    FrmAutorCreate frmAutorCreate = new FrmAutorCreate();

                    if (DialogResult.OK == frmAutorCreate.ShowDialog())
                    {
                        MessageBox.Show("Alta de Autor correcta!!", "Insertar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBoxes(1);
                        cbAutor.SelectedItem = cbAutor.Items[cbAutor.Items.Count - 1];
                    }
                    else
                    {
                        cbAutor.SelectedItem = cbAutor.Items[0];
                    }
                }
                else if (sender == cbClasificacion && cbClasificacion.SelectedIndex == 1)
                {
                    FrmClasificacionCreate frmClasificacionCreate = new FrmClasificacionCreate();

                    if (DialogResult.OK == frmClasificacionCreate.ShowDialog())
                    {
                        MessageBox.Show("Alta de Clasificación correcta!!", "Insertar Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBoxes(3);
                        cbClasificacion.SelectedItem = cbClasificacion.Items[cbClasificacion.Items.Count - 1];
                    }
                    else
                    {
                        cbClasificacion.SelectedItem = cbClasificacion.Items[0];
                    }
                }
                else if (sender == cbEditorial && cbEditorial.SelectedIndex == 1)
                {
                    FrmEditorialCreate frmEditorialCreate = new FrmEditorialCreate();

                    if (DialogResult.OK == frmEditorialCreate.ShowDialog())
                    {
                        MessageBox.Show("Alta de Editorial correcta!!", "Insertar Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBoxes(2);
                        cbEditorial.SelectedItem = cbEditorial.Items[cbEditorial.Items.Count - 1];
                    }
                    else
                    {
                        cbEditorial.SelectedItem = cbEditorial.Items[0];
                    }
                }
                else if (sender == cbGenero && cbGenero.SelectedIndex == 1)
                {
                    FrmGeneroCreate frmGeneroCrate = new FrmGeneroCreate();

                    if (DialogResult.OK == frmGeneroCrate.ShowDialog())
                    {
                        MessageBox.Show("Alta de Género correcta!!", "Insertar Género", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarComboBoxes(4);
                        cbGenero.SelectedItem = cbGenero.Items[cbGenero.Items.Count - 1];
                    }
                    else
                    {
                        cbGenero.SelectedItem = cbGenero.Items[0];
                    }
                }
            }
        }

        private void ComboBoxes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (sender == cbAutor)
            {
                NewAutor n = (NewAutor)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);

                    e.Graphics.DrawString(n.NombreCompleto, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    e.DrawBackground();
                    e.Graphics.DrawString(n.NombreCompleto, tbTitulo.Font,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
            else if (sender == cbClasificacion)
            {
                Clasificacion n = (Clasificacion)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);

                    e.Graphics.DrawString(n.Descripcion, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    e.DrawBackground();
                    e.Graphics.DrawString(n.Descripcion, tbTitulo.Font,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
            else if (sender == cbGenero)
            {
                Genero n = (Genero)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);

                    e.Graphics.DrawString(n.Descripcion, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    e.DrawBackground();
                    e.Graphics.DrawString(n.Descripcion, tbTitulo.Font,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
            else if (sender == cbEditorial)
            {
                NewEditorial n = (NewEditorial)((ComboBox)sender).Items[e.Index];
                if (e.Index == 1)
                {
                    Font f = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Underline);
                    e.Graphics.DrawString(n.RazonSocialCp, f,
                new SolidBrush(Color.Green), e.Bounds.X, e.Bounds.Y);
                }
                else
                {
                    e.DrawBackground();
                    e.Graphics.DrawString(n.RazonSocialCp, tbTitulo.Font,
                new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
                }
                e.DrawFocusRectangle();
            }
        }
    }
}


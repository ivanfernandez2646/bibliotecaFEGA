using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.Datos;
using UWP.Model;
using UWP.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.View
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class LibroPage : Page
    {
        public LibroPageViewModel libroPageViewModel { get; set; }
        private Object filtroSeleccionado;

        public LibroPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (!this.Frame.CanGoBack)
            {
                btAtras.Visibility = Visibility.Collapsed;
            }
            else
            {
                btAtras.Visibility = Visibility;
            }

            lvLibros.SelectedIndex = 0;

            try
            {
                filtroSeleccionado = e.Parameter;
                libroPageViewModel = new LibroPageViewModel(filtroSeleccionado);
            }
            catch (Exception ex)
            {
                libroPageViewModel = new LibroPageViewModel(new Object());
            }
        }

        private void btPrev_Click(object sender, RoutedEventArgs e)
        {
            if (lvLibros.SelectedIndex != 0)
            {
                lvLibros.SelectedIndex -= 1;
            }
            else
            {
                lvLibros.SelectedIndex = libroPageViewModel.Libros.Count - 1;
            }
        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            if (lvLibros.SelectedIndex != libroPageViewModel.Libros.Count - 1)
            {
                lvLibros.SelectedIndex += 1;
            }
            else
            {
                lvLibros.SelectedIndex = 0;
            }
        }

        private void btAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void lvLibros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollViewer scrollViewer = lvLibros.Parent as ScrollViewer;
            if (scrollViewer != null)
            {
                var container = lvLibros.ContainerFromItem(lvLibros.SelectedItem);
                var item = container as ListViewItem;
                var objTransf = item.TransformToVisual(lvLibros);
                Point point = objTransf.TransformPoint(new Point(0, 0));

                scrollViewer.ChangeView(point.X, 0, 1);
            }
        }
    }
}

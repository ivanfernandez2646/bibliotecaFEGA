using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.Datos;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace UWP.View
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private String contraseniaAdministrador;

        public MainPage()
        {
            this.InitializeComponent();
            contraseniaAdministrador = LogicaCerrarAplicacion.getActualPasswordAdministrador();
        }

        private async void NavigationViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CerrarAppUserControl cerrarAppUserControl = new CerrarAppUserControl();

            ContentDialog contentDialog = new ContentDialog()
            {
                Title = "Salir",
                Content = cerrarAppUserControl,
                PrimaryButtonText = "Aceptar",
                CloseButtonText = "Salir",
                DefaultButton = ContentDialogButton.Close
            };

            ContentDialogResult contentDialogResult = await contentDialog.ShowAsync();
            if(contentDialogResult == ContentDialogResult.Primary)
            {
                if (LogicaCerrarAplicacion.getPassword("12345678Z",cerrarAppUserControl.Contrasenia) == contraseniaAdministrador)
                {
                    Application.Current.Exit();
                }
            }
        }

        private void MenuLateral_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem nvi = (NavigationViewItem)sender.SelectedItem;
            if (nvi.Name.Equals("itemCatalogo")) 
            {
                frame.Navigate(typeof(LibroPage));
            } 
            else if (nvi.Name.Equals("itemClasificaciones")) 
            {
                frame.Navigate(typeof(ClasificacionPage));
            }
            else if (nvi.Name.Equals("itemGeneros"))
            {
                frame.Navigate(typeof(GeneroPage));
            }
        }
    }
}

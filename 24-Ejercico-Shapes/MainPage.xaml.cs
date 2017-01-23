using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _24_Ejercico_Shapes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mueveTriangulo.Begin();
        }

        private void Button_elipse(object sender, RoutedEventArgs e)
        {
            girarElipse.Begin();
        }

        private void Button_Trump(object sender, RoutedEventArgs e)
        {
            saludaTramp.Begin();
        }
        private void Button_newell(object sender, RoutedEventArgs e)
        {
            saludaNewell.Begin();
        }
        private void Button_obama(object sender, RoutedEventArgs e)
        {
            saludaObama.Begin();
        }

        private void Button_lucha(object sender, RoutedEventArgs e)
        {
            saludaTramp.Begin();
            saludaObama.Begin();
            saludaNewell.Begin();
        }
    }
}

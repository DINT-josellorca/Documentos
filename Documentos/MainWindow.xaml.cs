using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Alto = 500f;
            Ancho = 500f;
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            Configuracion configuracionVentana = new Configuracion();
            configuracionVentana.Owner = this;
            configuracionVentana.Alto = this.Alto;
            configuracionVentana.Ancho = this.Ancho;
            configuracionVentana.ShowDialog();
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            NuevoDocumento ventanaDocumento = new NuevoDocumento();
            ventanaDocumento.Owner = this;
            ventanaDocumento.Height = Alto;
            ventanaDocumento.Width = Ancho;
            ventanaDocumento.Show();
        }
    }
}

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
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public float Ancho { get; set; }
        public float Alto { get; set; }

        public Configuracion()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Ancho = float.Parse(AnchoTextBox.Text);
            Alto = float.Parse(AltoTextBox.Text);
            (Owner as MainWindow).Ancho = this.Ancho;
            (Owner as MainWindow).Alto = this.Alto;
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

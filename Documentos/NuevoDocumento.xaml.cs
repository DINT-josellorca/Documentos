using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para NuevoDocumento.xaml
    /// </summary>
    public partial class NuevoDocumento : Window
    {
        public NuevoDocumento()
        {
            InitializeComponent();
        }

        private void NuevoDocumentoWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Owner,"¿Seguro que quieres cerrar la ventana?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question,MessageBoxResult.No);
            e.Cancel = result != MessageBoxResult.Yes;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, DocumentoTextBox.Text);
            }
        }
    }
}

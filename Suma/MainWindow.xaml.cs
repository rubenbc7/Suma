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

namespace Suma
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Background = Brushes.Blue;
        }

        private void BtnSumar_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse (txtNumero1.Text);
            int numero2 = int.Parse(txtNUmero2.Text);
            int resultado = numero1 + numero2;
            lblResultado.Text = resultado.ToString();
        }
    }
}

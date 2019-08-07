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

namespace CalculadoraWpf.Views
{
    /// <summary>
    /// Interaction logic for ucTaskBar.xaml
    /// </summary>
    public partial class ucTaskBar : UserControl
    {
        public ucTaskBar()
        {
            InitializeComponent();
        }

        

        private void Soma_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(primeironumero.Text) + Int32.Parse(segundonumero.Text);
            Resultado.Text = output.ToString();
        }

        private void Subtrai_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(primeironumero.Text) - Int32.Parse(segundonumero.Text);
            Resultado.Text = output.ToString();

        }

        private void Multiplica_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(primeironumero.Text) * Int32.Parse(segundonumero.Text);
            Resultado.Text = output.ToString();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(primeironumero.Text) / Int32.Parse(segundonumero.Text);
            Resultado.Text = output.ToString();
        }

        public event EventHandler superatomica;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            superatomica(null, new EventArgs());
        }
    }
}

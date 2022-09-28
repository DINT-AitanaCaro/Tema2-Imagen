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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opaltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)opaltaRadioButton.IsChecked) imagenImage.Opacity = 1.0;
        }

        private void opmediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)opmediaRadioButton.IsChecked) imagenImage.Opacity = 0.6;
        }

        private void opbajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)opbajaRadioButton.IsChecked) imagenImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rellenoRadioButton.IsChecked) imagenImage.Stretch = Stretch.Fill;
        }
        
        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)uniformeRadioButton.IsChecked) imagenImage.Stretch = Stretch.Uniform;
        }
        
        private void rellenouniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rellenouniformeRadioButton.IsChecked) imagenImage.Stretch = Stretch.UniformToFill;
        }
        
        private void ningunoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)ningunoRadioButton.IsChecked) imagenImage.Stretch = Stretch.None;
        }
    }
}

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

namespace fabrica
{
    /// <summary>
    /// Логика взаимодействия для WinFurniture.xaml
    /// </summary>
    public partial class WinFurniture : Window
    {
        public WinFurniture()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}

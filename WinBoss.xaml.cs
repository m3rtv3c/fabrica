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
    /// Логика взаимодействия для WinBoss.xaml
    /// </summary>
    public partial class WinBoss : Window
    {
        public WinBoss()
        {
            InitializeComponent();
        }

        private void ButtonIzdelia_Click(object sender, RoutedEventArgs e)
        {
            WinProduct winpro = new WinProduct();
            winpro.ShowDialog();
            
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

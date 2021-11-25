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
    /// Логика взаимодействия для StoreKeeper.xaml
    /// </summary>
    public partial class StoreKeeper : Window
    {
        public StoreKeeper()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void ButtonCloth_Click(object sender, RoutedEventArgs e)
        {
            WinCloth winCloth = new WinCloth();
            winCloth.ShowDialog();
            this.Close();
        }

        private void ButtonFurniture_Click(object sender, RoutedEventArgs e)
        {
            WinFurniture winfur = new WinFurniture();
            winfur.ShowDialog();
            this.Close();
        }
    }
}

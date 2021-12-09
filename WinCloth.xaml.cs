using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для WinCloth.xaml
    /// </summary>
    public partial class WinCloth : Window
    {
       
        public WinCloth()
        {
            InitializeComponent();
            var datacloth = Helper.GetContext().Cloth.ToList();
            DataGridCloth.ItemsSource = datacloth;
           
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            StoreKeeper store = new StoreKeeper();
            store.Show();
            this.Close();
           
            
        }
    }
}

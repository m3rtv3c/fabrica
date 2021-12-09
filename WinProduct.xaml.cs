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
    /// Логика взаимодействия для WinProduct.xaml
    /// </summary>
    public partial class WinProduct : Window
    {
       public int zxc;
        public WinProduct()
        {
            InitializeComponent();
            var prod = Helper.GetContext().Product.ToList();
            DataGridProd.ItemsSource = prod;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            if (zxc == 0)
            {
                WinManager winmanag = new WinManager();
                winmanag.Show();
                this.Close();
            }
            else
            {
                WinBoss winboss = new WinBoss();
                winboss.Show();
                this.Close();
            }

        }
    }
}

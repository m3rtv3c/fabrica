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
    /// Логика взаимодействия для WinReg.xaml
    /// </summary>
    public partial class WinReg : Window
    {
        public WinReg()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxLogin.Text) && !string.IsNullOrEmpty(PasswordBoxReg.Password) && !string.IsNullOrEmpty(TextBoxName.Text))
            {
                using (GarmentFactoruEntities1 db = new GarmentFactoruEntities1())
                {
                    User user = new User();
                    user.Login = TextBoxLogin.Text;
                    user.Password = PasswordBoxReg.Password;
                    user.Name = TextBoxName.Text;
                    user.Role = "Заказчик";
                    db.User.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);

                }

            }
            else
            {
                MessageBox.Show("Регистрация не успешна. Не заполнены поля логина ,пароля или наименования", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}

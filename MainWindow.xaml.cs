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

namespace fabrica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonGoReg_Click(object sender, RoutedEventArgs e)
        {
            WinReg winreg = new WinReg();
            winreg.Show();
            this.Close();
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxLogin.Text) && !string.IsNullOrEmpty(PasswordBoxPassword.Password))
            {
                try
                {
                    if (TextBoxLogin.Text == Helper.GetContext().User.FirstOrDefault(x => x.Login == TextBoxLogin.Text).Login
                    && PasswordBoxPassword.Password == Helper.GetContext().User.FirstOrDefault(x => x.Password == PasswordBoxPassword.Password).Password)
                    {
                        User user = Helper.GetContext().User.Find(TextBoxLogin.Text);
                        switch (user.Role)
                        {
                            case "Заказчик":
                                WInCustomer winCustomer = new WInCustomer();
                                winCustomer.Show();
                                this.Close();
                                break;
                            case "Менеджер":
                                WinManager winManager = new WinManager();
                                winManager.Show();
                                this.Close();
                                break;
                            case "Директор":
                                WinBoss winDirector = new WinBoss();
                                winDirector.Show();
                                this.Close();
                                break;
                            case "Кладовщик":
                               StoreKeeper winStorekeeper = new StoreKeeper();
                                winStorekeeper.Show();
                                this.Close();
                                break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Авторизация не успешна. Не верны логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Авторизация не успешна. Не верны логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonzaglyshka_Click(object sender, RoutedEventArgs e)
        {
            WinCloth wincloth = new WinCloth();
            wincloth.Show();
            this.Close();
        }
    }
}


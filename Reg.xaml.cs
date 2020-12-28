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

namespace Ex
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.MyFrameLoad.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int pas = pasBox.Password.GetHashCode();
            int pass = passBox.Password.GetHashCode();
            if(pas != pass)
            {
                MessageBox.Show("Пароли не совподают!");
            }
            else
            {
                Login UserObject = new Login()
                {
                    login1 = logBox.Text,
                    password = pass,
                    idRole = 3
                };
                BaseConnect.BaseModel.Logins.Add(UserObject);
                BaseConnect.BaseModel.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
                MyFrame.MyFrameLoad.Navigate(new Main());
            }
        }
    }
}

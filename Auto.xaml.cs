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
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int password = passBox.Password.GetHashCode();

            Login UserObject = BaseConnect.BaseModel.Logins.FirstOrDefault(u => u.login1 == logBox.Text && u.password == password);
            if(UserObject == null)
            {
                MessageBox.Show("Такого пользователя не существует.");
            }
            else
            {
                MyFrame.MyFrameLoad.Navigate(new Main());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.MyFrameLoad.GoBack();
        }
    }
}

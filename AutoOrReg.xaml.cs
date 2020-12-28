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
    /// Логика взаимодействия для AutoOrReg.xaml
    /// </summary>
    public partial class AutoOrReg : Page
    {
        public AutoOrReg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.MyFrameLoad.Navigate(new Auto());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.MyFrameLoad.Navigate(new Reg());
        }
    }
}

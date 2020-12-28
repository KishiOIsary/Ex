using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            vidR0.Text = "2135";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.MyFrameLoad.GoBack();
        }


        string Mov(int a, int b)
        {
            string otv = " ";
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    a = b;
                    otv = Convert.ToString(a, 2);
                    break;
                case 1:
                    a=b;
                    otv = Convert.ToString(a, 10);
                    break;
                case 2:
                    a = b;
                    otv = Convert.ToString(a, 16);
                    break;
            }
            return otv;
        }
        string Add(int a, int b)
        {
            string otv = " ";
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    a += b;
                    otv = Convert.ToString(a, 2);
                    break;
                case 1:
                    a += b;
                    otv = Convert.ToString(a, 10);
                    break;
                case 2:
                    a += b;
                    otv = Convert.ToString(a, 16);
                    break;
            }
            return otv;
        }
        string Sub(int a, int b)
        {
            string otv = " ";
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    a -= b;
                    otv = Convert.ToString(a, 2);
                    break;
                case 1:
                    a -= b;
                    otv = Convert.ToString(a, 10);
                    break;
                case 2:
                    a -= b;
                    otv = Convert.ToString(a, 16);
                    break;
            }
            return otv;
        }
        string Mul(int a, int b)
        {
            string otv = " ";
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    a = a * b;
                    otv = Convert.ToString(a, 2);
                    break;
                case 1:
                    a = a * b;
                    otv = Convert.ToString(a, 10);
                    break;
                case 2:
                    a = a * b;
                    otv = Convert.ToString(a, 16);
                    break;
            }
            return otv;
        }
        string Div(int a, int b)
        {
            string otv = " ";
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    a = a / b;
                    otv = Convert.ToString(a, 2);
                    break;
                case 1:
                    a = a / b;
                    otv = Convert.ToString(a, 10);
                    break;
                case 2:
                    a = a / b;
                    otv = Convert.ToString(a, 16);
                    break;
            }
            return otv;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if((txtR0 == null)|| (txtR1 == null)|| (txtR2 == null)|| (txtR3 == null)|| (txtX == null))
            {
                MessageBox.Show("Введите все аргументы!");
                
            }
            string str = command.Text;
            string[] str1 = str.Split(new char[] { ' ', ',','\n' });
            str1[1].ToUpper();
            str1[2].ToUpper();
            int r0 = Convert.ToInt32(txtR0.Text, 16);
            int r1 = Convert.ToInt32(txtR1.Text, 16);
            int r2 = Convert.ToInt32(txtR2.Text, 16);
            int r3 = Convert.ToInt32(txtR3.Text, 16);
            int x = Convert.ToInt32(txtX.Text, 16);
            string res0 = Convert.ToString(r0,16);
            string res1 = Convert.ToString(r1, 16);
            string res2 = Convert.ToString(r2, 16);
            string res3 = Convert.ToString(r3, 16);
            switch (str1[0])
            {
                case "mov":
                    switch (str1[1])
                    {
                        case "R0":
                            switch (str1[2])
                            {
                                case "R0":
                                    res0 = Mov(r0, r0);
                                    break;
                                case "R1":
                                    res0 = Mov(r0, r1);
                                    break;
                                case "R2":
                                    res0 = Mov(r0, r2);
                                    break;
                                case "R3":
                                    res0 = Mov(r0, r3);
                                    break;
                                case "X":
                                    res0 = Mov(r0, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R1":
                            switch (str1[2])
                            {
                                case "R0":
                                    res1 = Mov(r1, r0);
                                    break;
                                case "R1":
                                    res1 = Mov(r1, r1);
                                    break;
                                case "R2":
                                    res1 = Mov(r1, r2);
                                    break;
                                case "R3":
                                    res1 = Mov(r1, r3);
                                    break;
                                case "X":
                                    res1 = Mov(r1, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R2":
                            switch (str1[2])
                            {
                                case "R0":
                                    res2 = Mov(r2, r0);
                                    break;
                                case "R1":
                                    res2 = Mov(r2, r1);
                                    break;
                                case "R2":
                                    res2 = Mov(r2, r2);
                                    break;
                                case "R3":
                                    res2 = Mov(r2, r3);
                                    break;
                                case "X":
                                    res2 = Mov(r2, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R3":
                            switch (str1[2])
                            {
                                case "R0":
                                    res3 = Mov(r3, r0);
                                    break;
                                case "R1":
                                    res3 = Mov(r3, r1);
                                    break;
                                case "R2":
                                    res3 = Mov(r3, r2);
                                    break;
                                case "R3":
                                    res3 = Mov(r3, r3);
                                    break;
                                case "X":
                                    res3 = Mov(r3, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("Некорректно введены команды!");
                            break;
                    }
                    break;
                case "add":
                    switch (str1[1])
                    {
                        case "R0":
                            switch (str1[2])
                            {
                                case "R0":
                                    res0 = Add(r0, r0);
                                    break;
                                case "R1":
                                    res0 = Add(r0, r1);
                                    break;
                                case "R2":
                                    res0 = Add(r0, r2);
                                    break;
                                case "R3":
                                    res0 = Add(r0, r3);
                                    break;
                                case "X":
                                    res0 = Add(r0, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R1":
                            switch (str1[2])
                            {
                                case "R0":
                                    res1 = Add(r1, r0);
                                    break;
                                case "R1":
                                    res1 = Add(r1, r1);
                                    break;
                                case "R2":
                                    res1 = Add(r1, r2);
                                    break;
                                case "R3":
                                    res1 = Add(r1, r3);
                                    break;
                                case "X":
                                    res1 = Add(r1, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R2":
                            switch (str1[2])
                            {
                                case "R0":
                                    res2 = Add(r2, r0);
                                    break;
                                case "R1":
                                    res2 = Add(r2, r1);
                                    break;
                                case "R2":
                                    res2 = Add(r2, r2);
                                    break;
                                case "R3":
                                    res2 = Add(r2, r3);
                                    break;
                                case "X":
                                    res2 = Add(r2, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R3":
                            switch (str1[2])
                            {
                                case "R0":
                                    res3 = Add(r3, r0);
                                    break;
                                case "R1":
                                    res3 = Add(r3, r1);
                                    break;
                                case "R2":
                                    res3 = Add(r3, r2);
                                    break;
                                case "R3":
                                    res3 = Add(r3, r3);
                                    break;
                                case "X":
                                    res3 = Add(r3, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("Некорректно введены команды!");
                            break;
                    }
                    break;
                case "sub":
                    switch (str1[1])
                    {
                        case "R0":
                            switch (str1[2])
                            {
                                case "R0":
                                    res0 = Sub(r0, r0);
                                    break;
                                case "R1":
                                    res0 = Sub(r0, r1);
                                    break;
                                case "R2":
                                    res0 = Sub(r0, r2);
                                    break;
                                case "R3":
                                    res0 = Sub(r0, r3);
                                    break;
                                case "X":
                                    res0 = Sub(r0, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R1":
                            switch (str1[2])
                            {
                                case "R0":
                                    res1 = Sub(r1, r0);
                                    break;
                                case "R1":
                                    res1 = Sub(r1, r1);
                                    break;
                                case "R2":
                                    res1 = Sub(r1, r2);
                                    break;
                                case "R3":
                                    res1 = Sub(r1, r3);
                                    break;
                                case "X":
                                    res1 = Sub(r1, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R2":
                            switch (str1[2])
                            {
                                case "R0":
                                    res2 = Sub(r2, r0);
                                    break;
                                case "R1":
                                    res2 = Sub(r2, r1);
                                    break;
                                case "R2":
                                    res2 = Sub(r2, r2);
                                    break;
                                case "R3":
                                    res2 = Sub(r2, r3);
                                    break;
                                case "X":
                                    res2 = Sub(r2, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R3":
                            switch (str1[2])
                            {
                                case "R0":
                                    res3 = Sub(r3, r0);
                                    break;
                                case "R1":
                                    res3 = Sub(r3, r1);
                                    break;
                                case "R2":
                                    res3 = Sub(r3, r2);
                                    break;
                                case "R3":
                                    res3 = Sub(r3, r3);
                                    break;
                                case "X":
                                    res3 = Sub(r3, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("Некорректно введены команды!");
                            break;
                    }
                    break;
                case "mul":
                    switch (str1[1])
                    {
                        case "R0":
                            switch (str1[2])
                            {
                                case "R0":
                                    res0 = Mul(r0, r0);
                                    break;
                                case "R1":
                                    res0 = Mul(r0, r1);
                                    break;
                                case "R2":
                                    res0 = Mul(r0, r2);
                                    break;
                                case "R3":
                                    res0 = Mul(r0, r3);
                                    break;
                                case "X":
                                    res0 = Mul(r0, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R1":
                            switch (str1[2])
                            {
                                case "R0":
                                    res1 = Mul(r1, r0);
                                    break;
                                case "R1":
                                    res1 = Mul(r1, r1);
                                    break;
                                case "R2":
                                    res1 = Mul(r1, r2);
                                    break;
                                case "R3":
                                    res1 = Mul(r1, r3);
                                    break;
                                case "X":
                                    res1 = Mul(r1, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R2":
                            switch (str1[2])
                            {
                                case "R0":
                                    res2 = Mul(r2, r0);
                                    break;
                                case "R1":
                                    res2 = Mul(r2, r1);
                                    break;
                                case "R2":
                                    res2 = Mul(r2, r2);
                                    break;
                                case "R3":
                                    res2 = Mul(r2, r3);
                                    break;
                                case "X":
                                    res2 = Mul(r2, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R3":
                            switch (str1[2])
                            {
                                case "R0":
                                    res3 = Mul(r3, r0);
                                    break;
                                case "R1":
                                    res3 = Mul(r3, r1);
                                    break;
                                case "R2":
                                    res3 = Mul(r3, r2);
                                    break;
                                case "R3":
                                    res3 = Mul(r3, r3);
                                    break;
                                case "X":
                                    res3 = Mul(r3, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("Некорректно введены команды!");
                            break;
                    }
                    break;
                case "div":
                    switch (str1[1])
                    {
                        case "R0":
                            switch (str1[2])
                            {
                                case "R0":
                                    res0 = Div(r0, r0);
                                    break;
                                case "R1":
                                    res0 = Div(r0, r1);
                                    break;
                                case "R2":
                                    res0 = Div(r0, r2);
                                    break;
                                case "R3":
                                    res0 = Div(r0, r3);
                                    break;
                                case "X":
                                    res0 = Div(r0, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R1":
                            switch (str1[2])
                            {
                                case "R0":
                                    res1 = Div(r1, r0);
                                    break;
                                case "R1":
                                    res1 = Div(r1, r1);
                                    break;
                                case "R2":
                                    res1 = Div(r1, r2);
                                    break;
                                case "R3":
                                    res1 = Div(r1, r3);
                                    break;
                                case "X":
                                    res1 = Div(r1, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R2":
                            switch (str1[2])
                            {
                                case "R0":
                                    res2 = Div(r2, r0);
                                    break;
                                case "R1":
                                    res2 = Div(r2, r1);
                                    break;
                                case "R2":
                                    res2 = Div(r2, r2);
                                    break;
                                case "R3":
                                    res2 = Div(r2, r3);
                                    break;
                                case "X":
                                    res2 = Div(r2, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        case "R3":
                            switch (str1[2])
                            {
                                case "R0":
                                    res3 = Div(r3, r0);
                                    break;
                                case "R1":
                                    res3 = Div(r3, r1);
                                    break;
                                case "R2":
                                    res3 = Div(r3, r2);
                                    break;
                                case "R3":
                                    res3 = Div(r3, r3);
                                    break;
                                case "X":
                                    res3 = Div(r3, x);
                                    break;
                                default:
                                    MessageBox.Show("Некорректно введены команды!");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("Некорректно введены команды!");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Некорректно введены команды!");
                    break;
            }
            int cmb = systemaSch.SelectedIndex;
            switch (cmb)
            {
                case 0:
                    res0 = Convert.ToString(Convert.ToInt32(res0, 16), 2);
                    res1 = Convert.ToString(Convert.ToInt32(res1, 16), 2);
                    res2 = Convert.ToString(Convert.ToInt32(res2, 16), 2);
                    res3 = Convert.ToString(Convert.ToInt32(res3, 16), 2);
                    break;
                case 1:
                    res0 = Convert.ToString(Convert.ToInt32(res0, 16), 10);
                    res1 = Convert.ToString(Convert.ToInt32(res1, 16), 10);
                    res2 = Convert.ToString(Convert.ToInt32(res2, 16), 10);
                    res3 = Convert.ToString(Convert.ToInt32(res3, 16), 10);
                    break;
                case 2:
                    res0 = Convert.ToString(Convert.ToInt32(res0,16), 16);
                    res1 = Convert.ToString(Convert.ToInt32(res1,16), 16);
                    res2 = Convert.ToString(Convert.ToInt32(res2, 16), 16);
                    res3 = Convert.ToString(Convert.ToInt32(res3, 16), 16);
                    break;
            }
            vidR0.Text = res0;
            txtR0.Text = res0;
            vidR1.Text = res1;
            txtR1.Text = res1;
            vidR2.Text = res2;
            txtR2.Text = res2;
            vidR3.Text = res3;
            txtR3.Text = res3;
        }
    }
}

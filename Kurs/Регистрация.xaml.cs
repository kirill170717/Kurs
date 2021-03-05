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

namespace Kurs
{
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }
        private void Button_Reg(object sender, RoutedEventArgs e)
        { 
                MethReg methReg = new MethReg();
                methReg.Button_Reg(TxtLogin.Text, PasPassword.Password, TxtФамилия.Text, TxtИмя.Text, TxtОтчество.Text, TxtНомер.Text);
                Авторизация авт = new Авторизация();
                авт.Show();
                Close();     
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Авторизация авт = new Авторизация();
            авт.Show();
            Close();
        }
    }
}
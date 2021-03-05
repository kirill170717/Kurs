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
    /// <summary>
    /// Логика взаимодействия для Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        gr691_tkpEntities db = new gr691_tkpEntities();
        public Administration()
        {
            InitializeComponent();
            Таб_Тренеры.ItemsSource = db.Kurs_Trainer.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 2).ToList();
        }
    }
}

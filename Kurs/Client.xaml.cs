﻿using System;
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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        gr691_tkpEntities db = new gr691_tkpEntities();
        public Client()
        {
            InitializeComponent();
            Таб_Клиенты.ItemsSource = db.Client.ToList();
            Таб_Клиенты.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 3).ToList();
        }
    }
}

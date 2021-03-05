using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    class Idd
    {
        public static int ClientI = 0;
        public static int TrainerI = 0;
        public static int UnitI = 0;
    }
    public class MethAuth
    {
        public bool Button_Auth(string TxtLogin, string PasPassword)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_User kurs_User = db.Kurs_User.FirstOrDefault(i => i.Логин == TxtLogin);
            if (string.IsNullOrWhiteSpace(TxtLogin) || string.IsNullOrWhiteSpace(PasPassword))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else if (kurs_User != null)
            {
                if (kurs_User.Логин == TxtLogin && kurs_User.Пароль == PasPassword)
                {
                    if (kurs_User.RoleId == 1)
                    {
                        
                    }
                    else if (kurs_User.RoleId == 2)
                    {
                        
                    }
                    else if (kurs_User.RoleId == 3)
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует");
                return false;
            }
            return true;
        }
    }
}
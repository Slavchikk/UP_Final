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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
            btnEnter.IsEnabled = false;
        }

        private void TbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

               // int paswordCode = TbPasAvto.Password.GetHashCode();
                USERS User = Base.EM.USERS.FirstOrDefault(z => z.NUMBER == TbNumber.Text);
                if (User == null)
                {
                    MessageBox.Show("Вы не зарегистрированы");
                    
                }
                else
                {
                    btnEnter.IsEnabled = true;
                }
                TbPasReg.Focus();
                //User = Base.EM.users.FirstOrDefault(z => z.login == TbLoginAvto.Text && z.password == paswordCode);
                //if (User == null)
                //    MessageBox.Show("Пароль введен неверно");
                //else
                //{
                //    switch (User.id_role)
                //    {
                //        case 1:
                //            MessageBox.Show("Здравствуйте, администратор " + User.name);
                //            // переход в меню администратора
                //            NavigationService.Navigate(new AdminMenuPage(User));
                //            break;
                //        case 2:
                //            MessageBox.Show("Здравствуйте, пользователь " + User.name);
                //            NavigationService.Navigate(new UserMenuPage(User));  // переход в личный кабинет
                //            break;
                //    }
                //}

            }
        }
    }
}

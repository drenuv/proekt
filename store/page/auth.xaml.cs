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
using System.Data.Entity;

namespace store.page
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        electronic_shopEntities content = new electronic_shopEntities();
        
        public auth()
        {
            InitializeComponent();
        }

        private void Btn_auth_Click(object sender, RoutedEventArgs e)
        {

            var a = content.Users.Where(i => i.e_mail == Txt_mail.Text && i.password == Txt_password.Password).ToList();
            if (a.Count > 0)
            {

                if (a.FirstOrDefault().User_type.type_name != "Ban")
                {
                    clas.user.id = a.FirstOrDefault().id_user;
                    clas.user.role = a.FirstOrDefault().type;
                    if (clas.user.role <= 2)
                        clas.mainpage.MainFrame.Navigate(new page.Main());
                    else
                        clas.mainpage.MainFrame.Navigate(new page.Admin());
                    
                }
                else
                {
                    MessageBox.Show("YOU BANNED!");
                }

            }
            else MessageBox.Show("invalid username or password");
        }

        private void Btn_reg_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.Registration());
        }
    }
}

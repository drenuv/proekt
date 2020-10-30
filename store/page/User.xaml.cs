using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace store.page
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Page
    {
        private Users Users = new Users();

        public User()
        {
            Users = electronic_shopEntities.GetContext().Users.FirstOrDefault(i => i.id_user == clas.user.id);
            InitializeComponent();
            DataContext = Users;
            cmb_Gender.ItemsSource = electronic_shopEntities.GetContext().Gender.ToList();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(Txt_mail.Text) || string.IsNullOrEmpty(Txt_name.Text))
            {
                errors.AppendLine("Write all text with *");
            }
            else
            {
                if (!Regex.IsMatch(Txt_mail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") || Txt_mail.Text.Length < 6)
                {
                    errors.AppendLine("write real email");
                }
            }
            

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Your change save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_new_pas_Click(object sender, RoutedEventArgs e)
        {
            DialogPassword dlg = new DialogPassword(true, Users);
            dlg.ShowDialog();
        }
    }
}

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
    /// Логика взаимодействия для UserEditCurrent.xaml
    /// </summary>
    public partial class UserEditCurrent : Page
    {
        private Users _CurrentUser = new Users();

        public UserEditCurrent(Users _SelectUser)
        {
            InitializeComponent();

            _CurrentUser = _SelectUser;
            DataContext = _CurrentUser;
            cmb_Gender.ItemsSource = electronic_shopEntities.GetContext().Gender.ToList();
            cmb_Type.ItemsSource = electronic_shopEntities.GetContext().User_type.ToList();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(Txt_mail.Text) || string.IsNullOrEmpty(Txt_name.Text) || cmb_Type.SelectedIndex < 0)
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
            DialogPassword dlg = new DialogPassword(false, (sender as Button).DataContext as Users);
            dlg.ShowDialog();
        }
    }
}

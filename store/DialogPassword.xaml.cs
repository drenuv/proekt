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
using System.Text.RegularExpressions;

namespace store
{
    /// <summary>
    /// Логика взаимодействия для DialogPassword.xaml
    /// </summary>
    public partial class DialogPassword : Window
    {
        private bool OldPassword;
        private Users _CurrentUser = new Users();
        public DialogPassword(bool OldPassword, Users _SelectedUsers)
        {
            this.OldPassword = OldPassword;
            InitializeComponent();
            if (OldPassword)
            {
                txt_old.Visibility = Visibility.Visible;
                psw_old.Visibility = Visibility.Visible;
            }
            else
            {
                _CurrentUser = _SelectedUsers;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(psw_new.Password) || (string.IsNullOrEmpty(psw_old.Password) && psw_old.Visibility == Visibility.Visible) || string.IsNullOrEmpty(psw_new_confirm.Password))
            {
                errors.AppendLine("Write all text");
            }
            

            if (!Regex.IsMatch(psw_new.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,50}$"))
            {
                errors.AppendLine("Your password is very easy. The password must contain at least 1 digit, 1 uppercase letter, 1 lowercase letter, and be longer than 8 characters and shorter than 50.");

            }

            if (psw_new.Password != psw_new_confirm.Password)
            {
                errors.AppendLine("pass != confirm pass");
            }

            if (OldPassword && (psw_old.Password != _CurrentUser.password))
            {
                errors.AppendLine("Your old password was entered incorrectly");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                
                _CurrentUser.password = psw_new_confirm.Password;
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Your password was successfully changed");
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }
    }
}

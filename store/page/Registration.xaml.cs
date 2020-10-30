using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace store.page
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {

        public Registration()
        {
            InitializeComponent();
            Gender.ItemsSource = electronic_shopEntities.GetContext().Gender.ToList();
        }

        private void Btn_reg_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(Txt_mail.Text) || string.IsNullOrEmpty(Txt_name.Text) || string.IsNullOrEmpty(Txt_password.Password) || string.IsNullOrEmpty(Txt_password_con.Password))
            {
                errors.AppendLine("Write all text with *");
            }
            else
            {
                if (!Regex.IsMatch(Txt_mail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") || Txt_mail.Text.Length < 6)
                {
                    errors.AppendLine("write real email");
                }


                if (Txt_password.Password != Txt_password_con.Password)
                {
                    errors.AppendLine("pass != confirm pass");
                }

                if (!Regex.IsMatch(Txt_password.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,50}$"))
                {
                    errors.AppendLine("Your password is very easy. The password must contain at least 1 digit, 1 uppercase letter, 1 lowercase letter, and be longer than 8 characters and shorter than 50.");

                }
            }
            

            if (errors.Length >0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            Users users = new Users();
            users.e_mail = Txt_mail.Text;
            users.type = 1;


            if (string.IsNullOrEmpty(Txt_phone.Text))
                users.phone = Txt_phone.Text;
            users.name = Txt_name.Text;
            users.data_registration = DateTime.Now.Date;
            if (data_bithday.SelectedDate != null)
                users.birthday = DateTime.Parse(data_bithday.SelectedDate.ToString());
            if (Gender.SelectedIndex < 1)
                 users.gender = 4;

            try
            {
                users.data_registration = DateTime.Parse(DateTime.Now.ToShortDateString());
                users.type = 2;
                users.password = Txt_password.Password;
                electronic_shopEntities.GetContext().Users.Add(users);
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("You account secsefcul add");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}

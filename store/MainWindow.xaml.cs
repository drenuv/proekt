using System;
using System.Collections.Generic;
using System.IO;
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

namespace store
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new page.Main());
            clas.mainpage.MainFrame = MainFrame;
            
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

            if (clas.mainpage.MainFrame.CanGoBack)
            {
                Btn_Back.Visibility = Visibility.Visible;
            }
            else
            {
                Btn_Back.Visibility = Visibility.Hidden;
            }

            if (clas.user.id != 0)
            {
                Btn_logout.Visibility = Visibility.Visible;
                Btn_user.Visibility = Visibility.Visible;
                Btn_login.Visibility = Visibility.Hidden;
            }
            else
            {
                Btn_logout.Visibility = Visibility.Hidden;
                Btn_user.Visibility = Visibility.Hidden;
                Btn_login.Visibility = Visibility.Visible;
            }

            if (clas.user.role == 3 || clas.user.role == 4)
            {
                Btn_admin.Visibility = Visibility.Visible;
            }
            else
            {
                Btn_admin.Visibility = Visibility.Hidden;
            }
                
        }

        private void Btn_logout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?","Выход",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                clas.user.id = 0;
                clas.mainpage.MainFrame.Navigate(new page.Main());
                MainWindow newwindow = new MainWindow();
                newwindow.Show();
                this.Close();
                
            }
        }
        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.auth());
        }

        private void Btn_user_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.User());
        }

        private void Btn_deal_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.Basket());
        }

        private void Btn_admin_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.Admin());
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.Main());
        }

        private void MainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Content is Page Page)
            {
                this.Title = Page.Title;
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is Page Page)
            {
                //this.Title = Page.Title;
            }
        }
    }
}

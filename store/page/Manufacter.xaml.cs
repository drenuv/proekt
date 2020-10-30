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

namespace store.page
{
    /// <summary>
    /// Логика взаимодействия для Manufacter.xaml
    /// </summary>
    public partial class Manufacter : Page
    {

        public Manufacter()
        {
            InitializeComponent();
            
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.AddManufacter((sender as Button).DataContext as Manufacturers));
        }


        private void Btn_del_Click(object sender, RoutedEventArgs e)
        {
            var manufacter_for_delete = dtg_manufacter.SelectedItems.Cast<Manufacturers>().ToList();
            
            if (MessageBox.Show($"Your shure want to delete {manufacter_for_delete.Count()} element?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    electronic_shopEntities.GetContext().Manufacturers.RemoveRange(manufacter_for_delete);
                    electronic_shopEntities.GetContext().SaveChanges();

                    MessageBox.Show("Manufacter delete");

                    dtg_manufacter.ItemsSource = electronic_shopEntities.GetContext().Manufacturers.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.AddManufacter(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                //electronic_shopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dtg_manufacter.ItemsSource = electronic_shopEntities.GetContext().Manufacturers.ToList();

            }
        }
    }
}

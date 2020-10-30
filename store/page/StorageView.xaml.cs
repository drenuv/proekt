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
    /// Логика взаимодействия для StorageView.xaml
    /// </summary>
    public partial class StorageView : Page
    {
        public StorageView()
        {
            InitializeComponent();
            Update_search();
        }


        private void Update_search()
        {
            var cur = electronic_shopEntities.GetContext().Storage.ToList();

            cur = cur.Where(i => i.Products.name_product.Contains(txt_search.Text)).ToList();
            dtg_storage.ItemsSource = cur.OrderByDescending(p => p.id_storage);


        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                electronic_shopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Update_search();
            }
        }

        private void Txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_search();
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.StorageEdit((sender as Button).DataContext as Storage));
        }

        private void Btn_del_Click(object sender, RoutedEventArgs e)
        {
            var storage_for_delete = dtg_storage.SelectedItems.Cast<Storage>().ToList();

            if (MessageBox.Show($"Your shure want to delete {storage_for_delete.Count()} element?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    electronic_shopEntities.GetContext().Storage.RemoveRange(storage_for_delete);
                    electronic_shopEntities.GetContext().SaveChanges();

                    MessageBox.Show("Storage delete");

                    Update_search();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.StorageEdit(null));
        }
    }
}

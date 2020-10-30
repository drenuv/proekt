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
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        public ProductView()
        {
            InitializeComponent();

            var alltype = electronic_shopEntities.GetContext().Type_electronic.ToList();

            alltype.Insert(0, new Type_electronic
            {
                type_electronic1 = "ALL"
            });
            cmp_type.ItemsSource = alltype;

            chk_actual.IsChecked = true;
            cmp_type.SelectedIndex = 0;

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                electronic_shopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Update_search();
            }
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.ProductEdit(null));
        }

        

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.ProductEdit((sender as Button).DataContext as Products));
        }


        private void Btn_del_Click(object sender, RoutedEventArgs e)
        {
            var product_for_delete = dtg_product.SelectedItems.Cast<Products>().ToList();

            if (MessageBox.Show($"Your shure want to delete {product_for_delete.Count()} element?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    electronic_shopEntities.GetContext().Products.RemoveRange(product_for_delete);
                    electronic_shopEntities.GetContext().SaveChanges();

                    MessageBox.Show("Manufacter delete");

                    Update_search();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Update_search()
        {
            Type_electronic type_ = (Type_electronic)cmp_type.SelectedItem;
            var cur = electronic_shopEntities.GetContext().Products.ToList();

            if (chk_actual.IsChecked == true)
            {
                cur = cur.Where(i => i.amount > 0).ToList();
            }

            if (cmp_type.SelectedIndex > 0)
            {
                cur = cur.Where(i => type_.Type_products.Select(p => p.product).Contains(i.id_product)).ToList();
            }

            cur = cur.Where(i => i.name_product.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dtg_product.ItemsSource = cur.OrderBy(p => p.name_product);

        }

        private void Txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_search();
        }

        private void Cmp_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_search();
        }

        private void Chk_actual_Checked(object sender, RoutedEventArgs e)
        {
            Update_search();
        }

    }
}

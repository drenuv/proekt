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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {

        public Main()
        {
            InitializeComponent();

            var alltype = electronic_shopEntities.GetContext().Type_electronic.ToList();
            
            alltype.Insert(0, new Type_electronic
            {
                type_electronic1 = "ALL"
            });

            chk_actual.IsChecked = true;
            
            cmp_type.ItemsSource = alltype;
            cmp_type.SelectedIndex = 0;
            
            Update_search();
            
        }

        private void Update_search()
        {

            //получаем выбранный объект
            Type_electronic type_ = (Type_electronic)cmp_type.SelectedItem;
            var cur = electronic_shopEntities.GetContext().Type_products.ToList();

            if (chk_actual.IsChecked ==  true)
            {
                cur = cur.Where(i => i.Products.amount > 0).ToList();
            }

           

            if (cmp_type.SelectedIndex > 0) 
            {
                cur = cur.Where(i => i.type == type_.id_type_electronic).ToList();
 
            }

            cur = cur.Where(i => i.Products.name_product.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            lst_main.ItemsSource = cur.OrderBy(p => p.Products.name_product);

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

        private void Btn_add_basket_Click(object sender, RoutedEventArgs e)
        {
            clas.deals.basket.Add(((sender as Button).DataContext as Type_products).Products);
        }

        private void Btn_information_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.MoreProduct((sender as Button).DataContext as Type_products));
        }
    }
}
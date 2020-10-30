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
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        
        public Basket()
        {
            InitializeComponent();
            dtg_basket.ItemsSource = clas.deals.basket;
        }

        private void Btn_done_Click(object sender, RoutedEventArgs e)
        {
            if (clas.user.id == 0)
            {
                MessageBox.Show("You must be login in app.");
                return;
            }

            Deals deals = new Deals();
            deals.date_deal = DateTime.Now.Date;
            deals.users = clas.user.id;
            deals.status = 4;
            List<Deal_product> deal_Product = new List<Deal_product>();
            foreach (var item in clas.deals.basket)
            {
                Deal_product deal_ = new Deal_product();
                deal_.product = item.id_product;
                deals.Deal_product.Add(deal_);
            }

            try
            {
                electronic_shopEntities.GetContext().Deals.Add(deals);
                electronic_shopEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Your order is save. It is processed by the store.");
                clas.deals.basket.Clear();
                clas.mainpage.MainFrame.Navigate(new page.Main());
            }

        }

        private void Btn_clear_Click(object sender, RoutedEventArgs e)
        {
            clas.deals.basket.Clear();
            dtg_basket.ItemsSource = clas.deals.basket;
            VisibleButton();
        }

        private void Btn_del_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show($"Your shure want to delete {((sender as Button).DataContext as Products).name_product} in the basket?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                clas.deals.basket.Remove((sender as Button).DataContext as Products);
                dtg_basket.ItemsSource = clas.deals.basket;
                if (clas.deals.basket.Count < 1)
                {
                    VisibleButton();
                }
            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            VisibleButton();
        }

        private void VisibleButton()
        {
            if (clas.deals.basket.Count > 0)
            {
                btn_clear.Visibility = Visibility.Visible;
                btn_done.Visibility = Visibility.Visible;
            }
            else
            {
                btn_done.Visibility = Visibility.Hidden;
                btn_clear.Visibility = Visibility.Hidden;
            }
        }
    }
}

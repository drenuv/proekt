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
    /// Логика взаимодействия для DealEdit.xaml
    /// </summary>
    public partial class DealEdit : Page
    {
        private Deals _CurrentDeal = new Deals(); 
        public DealEdit(Deals _SelectDeal)
        {
            
            InitializeComponent();
            _CurrentDeal = _SelectDeal;
            DataContext = _CurrentDeal;
            dtg_product.DataContext = _CurrentDeal.Deal_product;
            cmb_status.ItemsSource = electronic_shopEntities.GetContext().Status_deal.ToList();
            dtg_product.ItemsSource = electronic_shopEntities.GetContext().Deals.FirstOrDefault(i => i.id_deal == _CurrentDeal.id_deal).Deal_product.ToList();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Product save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_del_Click(object sender, RoutedEventArgs e)
        {
            var sen = (sender as Button).DataContext as Deal_product;
            //var type_electronic_for_delete = dtg_manufacter.SelectedItems.Cast<Type_electronic>().ToList();

            if (MessageBox.Show($"Your shure want to delete {sen.Products.name_product} in deal?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    //electronic_shopEntities.GetContext().Type_electronic.RemoveRange(type_electronic_for_delete);
                    electronic_shopEntities.GetContext().Deal_product.Remove(sen);
                    electronic_shopEntities.GetContext().SaveChanges();

                    MessageBox.Show("Manufacter delete");

                    dtg_product.ItemsSource = electronic_shopEntities.GetContext().Deals.FirstOrDefault(i => i.id_deal == _CurrentDeal.id_deal).Deal_product.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}

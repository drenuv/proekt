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
    /// Логика взаимодействия для DealVIew.xaml
    /// </summary>
    public partial class DealVIew : Page
    {
        public DealVIew()
        {
            InitializeComponent();
            var alltype = electronic_shopEntities.GetContext().Status_deal.ToList();

            alltype.Insert(0, new Status_deal
            {
                 status_deal1= "ALL"
            });
            cmp_type.ItemsSource = alltype;
            cmp_type.SelectedIndex = 0;

        }

        private void Update_search()
        {
            Status_deal type_ = (Status_deal)cmp_type.SelectedItem;
            var cur = electronic_shopEntities.GetContext().Deals.ToList();


            if (cmp_type.SelectedIndex > 0)
            {
                cur = cur.Where(i => i.Status_deal.id_status_deal == type_.id_status_deal).ToList();
            }

            cur = cur.Where(i => i.id_deal.ToString().Contains(txt_search.Text)).ToList();
            dtg_deal.ItemsSource = cur.OrderByDescending(p => p.id_deal);
            

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                electronic_shopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Update_search();
            }

        }

        private void Cmp_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_search();
        }

        private void Txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_search();
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.DealEdit((sender as Button).DataContext as Deals));
        }
    }
}

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
    /// Логика взаимодействия для MoreProduct.xaml
    /// </summary>
    public partial class MoreProduct : Page
    {

        private Products _currentprod = new Products();

        public MoreProduct(Type_products selectmanufacter)
        {
            InitializeComponent();
            
            if (selectmanufacter != null)
            {
                _currentprod = selectmanufacter.Products;
            }

            //electronic_shopEntities.GetContext().Products.FirstOrDefault(i => i.Manufacturers.name)

            DataContext = _currentprod;
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            
            clas.deals.basket.Add(_currentprod);
        }
    }
}

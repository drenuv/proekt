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
    /// Логика взаимодействия для ProductEditTypeEdit.xaml
    /// </summary>
    public partial class ProductEditTypeEdit : Page
    {
        private Type_products _currenttype = new Type_products();

        public ProductEditTypeEdit(Type_products SelectProduct)
        {
            InitializeComponent();

            if(SelectProduct != null)
            {
                _currenttype = SelectProduct;
            }

            DataContext = _currenttype;
            cmb_type.ItemsSource = electronic_shopEntities.GetContext().Type_electronic.ToList();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {

            if (cmb_type.SelectedIndex < 0)
            {
                MessageBox.Show("type must be fill");
                return;
            }

            if (_currenttype.id_type_products == 0)
            {
                electronic_shopEntities.GetContext().Type_products.Add(_currenttype);

            }

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
    }
}

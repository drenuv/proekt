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
    /// Логика взаимодействия для StorageEdit.xaml
    /// </summary>
    public partial class StorageEdit : Page
    {
        private Storage _SelectStorage = new Storage();

        public StorageEdit(Storage _CurrentStorage)
        {
            InitializeComponent();
            if (_CurrentStorage != null)
            {
                _SelectStorage = _CurrentStorage;
            }
            DataContext = _SelectStorage;
            txt_name.Text = electronic_shopEntities.GetContext().Products.FirstOrDefault(i => i.id_product == _SelectStorage.product).name_product;
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (_SelectStorage.id_storage == 0)
            {
                electronic_shopEntities.GetContext().Storage.Add(_SelectStorage);

            }

            try
            {
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Storage save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Txt_id_LostFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Name == Txt_id.Name && long.TryParse(Txt_id.Text, out long id))
            {
                if (id <= electronic_shopEntities.GetContext().Products.ToList().Last().id_product)
                    txt_name.Text = electronic_shopEntities.GetContext().Products.FirstOrDefault(i => i.id_product == id).name_product;
            }
            else if (!long.TryParse((sender as TextBox).Text, out long test))
            {
                MessageBox.Show("This must be only numbers");
                (sender as TextBox).Focusable = true;
            }
        }

    }
}

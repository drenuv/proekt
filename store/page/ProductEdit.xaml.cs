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
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace store.page
{
    /// <summary>
    /// Логика взаимодействия для ProductEdit.xaml
    /// </summary>
    public partial class ProductEdit : Page
    {
        private Products _currentman = new Products();

        public ProductEdit(Products selectmanufacter)
        {
            InitializeComponent();

            if (selectmanufacter != null)
            {
                _currentman = selectmanufacter;
            }

            DataContext = _currentman;

            cmb_manufactures.ItemsSource = electronic_shopEntities.GetContext().Manufacturers.ToList();
            

        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_barcode.Text))
            {
                errors.AppendLine("fill in all fields except the description ");
            }
            else
            {
                if (txt_name.Text.Length > 50)
                {
                    errors.AppendLine("Manufacter lenght never more 50");
                }

                if (txt_barcode.Text.Length != 13 || Regex.IsMatch(txt_barcode.Text, @"^[0-9 ]+$"))
                {
                    errors.AppendLine("must consist of only 13 numbers");
                }

                if (Decimal.TryParse(txt_price.Text, out decimal dec))
                {
                    errors.AppendLine("Price must be numbers");

                }

                if (electronic_shopEntities.GetContext().Products.Where(i => i == _currentman) != null)
                {
                    errors.AppendLine("Your product alredy add.");
                }

            }
            if (electronic_shopEntities.GetContext().Products.First(i => i.barcode == txt_barcode.Text) != null)
            {
                return;
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
           

            if (_currentman.id_product == 0)
            {
                electronic_shopEntities.GetContext().Products.Add(_currentman);

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

        private void Btn_add_img_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (dialog.ShowDialog() == true)
            {
                _currentman.image = File.ReadAllBytes(dialog.FileName);
                img_prod.Source = new BitmapImage(new Uri(dialog.FileName));
                

            }
            
        }

        private void Btn_edit_type_Click(object sender, RoutedEventArgs e)
        {
            if (_currentman.id_product != 0)
            {
                clas.mainpage.MainFrame.Navigate(new page.ProductEditType(_currentman));
            }
            else
            {
                MessageBox.Show("first save the product");
            }
            
        }
    }
}

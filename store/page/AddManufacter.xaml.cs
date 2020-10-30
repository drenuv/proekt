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
    /// Логика взаимодействия для AddManufacter.xaml
    /// </summary>
    public partial class AddManufacter : Page
    {
        private Manufacturers _currentman = new Manufacturers();

        public AddManufacter(Manufacturers selectmanufacter)
        {
            InitializeComponent();
            
            if (selectmanufacter != null)
            {
                _currentman = selectmanufacter;
            }

            DataContext = _currentman;
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                errors.AppendLine("Write name");
            }
            else
            {
                if (txt_name.Text.Length > 50)
                {
                    errors.AppendLine("Manufacter lenght never more 50");
                }

                if (electronic_shopEntities.GetContext().Manufacturers.Where(i => i.name == txt_name.Text) != null)
                {
                    errors.AppendLine("Your manufacter alredy add.");
                }

            }


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            

            if (_currentman.id_manufacturer == 0)
            {
                electronic_shopEntities.GetContext().Manufacturers.Add(_currentman);

            }
            try
            {
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Manufacter save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

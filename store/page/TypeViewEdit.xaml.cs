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
    /// Логика взаимодействия для TypeViewEdit.xaml
    /// </summary>
    public partial class TypeViewEdit : Page
    {

        private Type_electronic _currentman = new Type_electronic();

        public TypeViewEdit(Type_electronic selectmanufacter)
        {
            InitializeComponent();


            if(selectmanufacter != null)
            {
                _currentman = selectmanufacter;
            }

            DataContext = _currentman;
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (_currentman.id_type_electronic == 0)
            {
                electronic_shopEntities.GetContext().Type_electronic.Add(_currentman);

            }

            if (txt_name.Text.Length > 50)
            {
                MessageBox.Show("Type lenght never more 50");
                return;
            }

            if (electronic_shopEntities.GetContext().Type_electronic.Where(i => i.type_electronic1 == txt_name.Text) != null)
            {
                MessageBox.Show("Your type alredy add.");
                return;
            }

            try
            {
                electronic_shopEntities.GetContext().SaveChanges();
                MessageBox.Show("Type save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

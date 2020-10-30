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
    /// Логика взаимодействия для UserEdit.xaml
    /// </summary>
    public partial class UserEdit : Page
    {
        public UserEdit()
        {
            InitializeComponent();
            var alltype = electronic_shopEntities.GetContext().User_type.ToList();

            alltype.Insert(0, new User_type
            {
                type_name = "ALL"
            });

            cmp_type.ItemsSource = alltype;
            cmp_type.SelectedIndex = 0;


            
        }


        private void Update_search()
        {
            
            //получаем выбранный объект
            User_type type_ = (User_type)cmp_type.SelectedItem;
            var cur = electronic_shopEntities.GetContext().Users.Where(i => i.type < clas.user.role).ToList();

            if (cmp_type.SelectedIndex > 0)
            {
                if (type_.id_type == 4)
                {
                    edit.Visibility = Visibility.Hidden;
                    cur = electronic_shopEntities.GetContext().Users.ToList();
                }
                else
                {
                    edit.Visibility = Visibility.Visible;
                }
                cur = cur.Where(i => i.type == type_.id_type).ToList();
            }

            cur = cur.Where(i => i.name.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dtg_user.ItemsSource = cur.OrderBy(p => p.name);

        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            clas.mainpage.MainFrame.Navigate(new page.UserEditCurrent((sender as Button).DataContext as Users));
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
    }
}

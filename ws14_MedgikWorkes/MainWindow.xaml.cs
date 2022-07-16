using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace ws14_MedgikWorkes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ws14Entities1 db = new ws14Entities1();
        public MainWindow()
        {
            
            InitializeComponent();
            var recepts = ws14Entities1.GetContext().Sotrudnikis.Where(x => x.Сотрудник != "NULL").ToList();
            ReceptView.ItemsSource = recepts;

        }
        public string DisplayedImage
        {
            get { return "/ws14_MedgikWorkesт/Images/Абрамова Артемида Вениаминовна.jpg"; }
        }

        private void fioPoiskTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var receptik = db.Sotrudnikis.Where(obj => DbFunctions.Like(obj.Сотрудник, "%"+fioPoiskTB.Text+"%"));
                ReceptView.ItemsSource = receptik.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void tvSections_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem treeItem = null;
            treeItem = new TreeViewItem();
            treeItem.Header = "Name";
            treeItem.Selected += treeItem_Selected;
        }

        void treeItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = sender as TreeViewItem;
            MessageBox.Show(item.ToString());
        }
    }
}

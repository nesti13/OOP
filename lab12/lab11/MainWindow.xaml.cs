using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace lab11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable phonesTable;
        public MainWindow()
        {
            InitializeComponent();
            Masters.ItemsSource = lab10Entities.GetContext().masters.ToList();
        }

        private void Masters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BinEdit_Click(object sender, RoutedEventArgs e)
        {

            Add window = new Add((sender as Button).DataContext as master);
            var master = Masters.SelectedItems.Cast<master>().ToList();
            lab10Entities.GetContext().masters.RemoveRange(master);
            lab10Entities.GetContext().SaveChanges();
            window.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var master = Masters.SelectedItems.Cast<master>().ToList();
            if(MessageBox.Show($"Вы точно хотите удалить следующие {master.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    lab10Entities.GetContext().masters.RemoveRange(master);
                    lab10Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    Masters.ItemsSource = lab10Entities.GetContext().masters.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnSQL_Click(object sender, RoutedEventArgs e)
        {
            using(lab10Entities db = new lab10Entities())
            {
                var forDel = db.masters.Where(p => p.name == First.Text);
                Masters.ItemsSource = forDel.ToList();
            }
        }

        private void BtnSQL2_Click(object sender, RoutedEventArgs e)
        {
            using (lab10Entities db = new lab10Entities())
            {
                var forDel = db.masters.Where(p => p.name == Second.Text);
                var forDel2 = forDel.Where(p => p.qualification == TRID.Text);
                Masters.ItemsSource = forDel2.ToList();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Add window = new Add(null);
            window.Show();
            this.Hide();
        }

    }
}

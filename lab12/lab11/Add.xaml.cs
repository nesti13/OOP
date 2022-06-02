using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
using System.Windows.Shapes;

namespace lab11
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public byte[] imageBytes;
        byte a = 1;
        private master master = new master();

        public Add(master selectmaster)
        {
            InitializeComponent();
            if (selectmaster != null)
            { master = selectmaster; }

            DataContext = master;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(id_master.Text))
                errors.AppendLine("Пустое id мастера");
            if (string.IsNullOrWhiteSpace(surname.Text))
                errors.AppendLine("Пустая Фамлия");
            if (string.IsNullOrWhiteSpace(name.Text))
                errors.AppendLine("Пустое Имя");
            if (string.IsNullOrWhiteSpace(education.Text))
                errors.AppendLine("Пустое Образование");
            if (string.IsNullOrWhiteSpace(qualification.Text))
                errors.AppendLine("Пустое поле Квалификации");
            if (string.IsNullOrWhiteSpace(work_expirience.Text))
                errors.AppendLine("Пустое поле Опыта работы");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            lab10Entities.GetContext().masters.Add(master);
            try
            {
                lab10Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                MessageBox.Show(path);
                byte[] imageBytesBuffer;
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    imageBytesBuffer = new byte[fs.Length];
                    fs.Read(imageBytesBuffer, 0, imageBytesBuffer.Length);
                }
                imageBytes = imageBytesBuffer;
            }
        }
    }
}

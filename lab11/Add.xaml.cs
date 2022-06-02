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
            string str = work_expirience.Text;
            if ((work_expirience.Text.Trim() == "") || (Convert.ToInt32(work_expirience.Text) == 0) || (Convert.ToInt32(work_expirience.Text) < 0))
            {
                work_expirience.ToolTip = "Это поле введено не корректно!";
                work_expirience.BorderBrush = Brushes.Red;
            }
            else if (surname.Text == "")
            {
                surname.ToolTip = "Это поле введено не корректно!";
                surname.BorderBrush = Brushes.Red;
            }

            else if (surname.Text == "")
            {
                name.ToolTip = "Это поле введено не корректно!";
                name.BorderBrush = Brushes.Red;
            }

            else if (name.Text == "")
            {
                education.ToolTip = "Это поле введено не корректно!";
                education.BorderBrush = Brushes.Red;
            }
            else if (education.Text == "")
            {
                education.ToolTip = "Это поле введено не корректно!";
                education.BorderBrush = Brushes.Red;
            }
            else if (qualification.Text == "")
            {
                qualification.ToolTip = "Это поле введено не корректно!";
                qualification.BorderBrush = Brushes.Red;
            }
            else
            {
                qualification.ToolTip = "";
                qualification.BorderBrush = Brushes.Transparent;


                try
                {
                    lab10Entities.GetContext().masters.Add(master);
                    lab10Entities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
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

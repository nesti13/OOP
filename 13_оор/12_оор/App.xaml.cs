
using _12_оор.Models;
using _12_оор.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _12_оор
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher("Курсы по с#", "Архипенко Александр", "100 часов", "15 человек", 15),
                new Teacher("Веб-разработка", "Николаева Евгения", "130 часов", "15 человек", 15),
                new Teacher("Курсы по веб-дизайну", "Некрасов Евгений", "75 часов", "15 человек", 15),
                new Teacher("Курсы по базам данных", "Соломонова Ева", "90 часов", "15 человек", 15)
            };

            MainWindow view = new MainWindow();
            MainViewModel viewModel = new MainViewModel(teachers);
            view.DataContext = viewModel;
            view.Show();
        }
    }
}

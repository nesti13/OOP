using _12_оор.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_оор.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TeacherViewModel> TeacherList { get; set; }
        #region Constructor
        public MainViewModel(List<Teacher> teachers)
        {
            TeacherList = new ObservableCollection<TeacherViewModel>(teachers.Select(b => new
           TeacherViewModel(b)));
        }
        #endregion
    }
}

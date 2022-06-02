using _12_оор.Commands;
using _12_оор.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _12_оор.ViewModels
{
    public class TeacherViewModel : ViewModelBase
    {
        public Teacher Teacher;
        public TeacherViewModel(Teacher teacher )
        {
            this.Teacher = teacher;
        }

        public string Course_Name
        {
            get { return Teacher.Course_Name; }
            set
            {
                Teacher.Course_Name = value;
                OnPropertyChanged("Course_Name");
            }
        }
        public string Teacher_Name
        {
            get { return Teacher.Teacher_Name; }
            set
            {
                Teacher.Teacher_Name = value;
                OnPropertyChanged("Teacher_Name");
            }
        }
        public string Lectures
        {
            get { return Teacher.Lectures; }
            set
            {
                Teacher.Lectures = value;
                OnPropertyChanged("Lectures");
            }
        }
        public string Students
        {
            get { return Teacher.Students; }
            set
            {
                Teacher.Students = value;
                OnPropertyChanged("Students");
            }
        }
        public int Taloncick {
            get { return Teacher.Taloncick; }
            set
            {
                Teacher.Taloncick = value;
                OnPropertyChanged("Taloncick");
            }
        }
        #region Commands
        #region Забрать

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            Taloncick++;
        }

        #endregion

        #region Выдать

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            Taloncick--;
        }

        private bool CanGiveItem()
        {
            return Taloncick > 0;
        }

        #endregion


        #endregion
    }
}

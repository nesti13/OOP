﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    
    public partial class Form1 : Form
    {
        int actionBack = 0;
        int actionForward = 0;
        public ITLab ITLab;
        public Form1()
        {
            InitializeComponent();
            Computer_Type.SelectedItem = "Ноутбук";
            Type_OZU.SelectedItem = "DDR4";
            TypeHD.SelectedItem = "HDD";
            ProcCount.SelectedItem = "1";
            MemoryCount.SelectedItem = "1 ГБ";
            DirectX.SelectedItem = "v. 9";
            ITLab = new ITLab();
            
            statusStrip1.Hide();
        }

        private void Add_Click(object sender, EventArgs e) // Добавить
        {
            
            if (Processor.Text.Equals(""))
            {
                MessageBox.Show("Введите название процессора");
                return;
            }
            
               Random rnd = new Random();
                Computer computer = new Computer
                {
                    
                    ComputerType = Computer_Type.Text,

                    /*Proc = new Proc
                    {

                        ProcName = Processor.Text,
                        ProcCount = int.Parse(ProcCount.Text)
                    },
                    Video = new Video
                    {
                        VideoName = Video_Name.Text,
                        VideoMemory = MemoryCount.Text,
                        DirectX = DirectX.Text
                    },
                    SizeOZU = int.Parse(SizeOZU.Text),
                    
                    SizeHD = int.Parse(SizeHD.Text),
                    TypeHD = TypeHD.Text,
                    Date = Date.Value*/
                    
                };
                //computerValidation.IsValid(computer);
                //ComputerValidation.Validate(computer);
                if (Type_OZU.Text == "DDR3")
                {
                    DDR3 type = new DDR3();
                    computer.TypeOZU = type.getMemory();
                }
                if (Type_OZU.Text == "DDR4")
                {
                    DDR4 type = new DDR4();
                    computer.TypeOZU = type.getMemory();
                }
                if (ComputerValidation.Validate(computer)==true)
                {
                    result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
                    ITLab.Computers.Add(computer);
                    Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
                    statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
                    actionBack = 1;
                } 
            
            //catch
            //{
            //    MessageBox.Show("Заполните все данные корректно");
            //}

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
            statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
            if (ITLab.Computers.Count==0)
            {
                MessageBox.Show("Нет данных для сохранения");
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
                using (FileStream stream = new FileStream(@"C:\Users\Admin\Desktop\ооп\Lab2\bin\Debug\netcoreapp3.1\Computers.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, ITLab);
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            result.Rows.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream(@"C:\Users\Admin\Desktop\ооп\Lab2\bin\Debug\netcoreapp3.1\Computers.xml", FileMode.Open))
            {
                ITLab = serializer.Deserialize(stream) as ITLab;
            }
            foreach (Computer computer in ITLab.Computers)
            {
                
                result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
               
            }
            Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
            
            statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
            actionBack = 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void размерОЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Rows.Clear(); 
            IEnumerable<Computer> ordered = ITLab.Computers.OrderBy(p => p.SizeOZU);
            foreach (Computer computer in ordered)
            {
                result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
            }
        }

        private void размерДискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Rows.Clear();
            IEnumerable<Computer> ordered = ITLab.Computers.OrderBy(p => p.SizeHD);
            foreach (Computer computer in ordered)
            {
                result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Колядко Яна Дмитриевна \nВерсия 1.0");
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream(@"C:\Users\Admin\Desktop\ооп\Lab2\bin\Debug\netcoreapp3.1\ComputersforSearch.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, ITLab);
            }
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        List<Computer> DeletedItems = new List<Computer>();
        
        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                DeletedItems.Add(ITLab.Computers[result.Rows.Count - 2]);
                result.Rows.RemoveAt(result.Rows.Count - 2);
            }
            catch
            {
                MessageBox.Show("Нет данных для удаления");
            }

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            try
            {
                var computer = DeletedItems.Last();
                result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
                DeletedItems.RemoveAt(DeletedItems.Count - 1);
            }
            catch
            {
                MessageBox.Show("Нет данных для добавления");
            }
        }

        private void info_Click_1(object sender, EventArgs e)
        {
            SingletonForm1 form1_info = SingletonForm1.getInstance(this.BackColor, this.Font, this.Size);
            MessageBox.Show(form1_info.ToString(), "Информация о форме");
        }

        private void clone_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            computer = Clone.AddClone(ITLab.Computers.Last());
            ITLab.Computers.Add(computer);
            result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
        }

        private void builder_Click(object sender, EventArgs e)
        {
            PageBuilder pageBuilder = new PageBuilder();
            Computer computer = new Computer();
            computer = pageBuilder.PostPage(1);
            //MessageBox.Show(pageBuilder.PostPage(1).ToString());
            ITLab.Computers.Add(computer);
            result.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
        }

        private void adapt_Click(object sender, EventArgs e)
        {
            VideoMemory x = new VideoMemory(2);
            Proc AMD = new Proc("AMD", 237);
            Video Intel = new Video("Intel", ".x11", x);
            Computer decor = new Computer("ноутбук", AMD, Intel, 64, "хд", 128, "пак", new DDR3OZU());
            MessageBox.Show($"{ decor.Decorator.ToString()}");
        }
    }
    public class ComputerValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Computer computer = value as Computer;
            if (computer.SizeHD%2==1)
            {
                ErrorMessage = "Такой памяти диска быть не может";
                return false;
            }
            else if (computer.SizeOZU % 2 == 1)
            {
                ErrorMessage = "Такой памяти ОЗУ быть не может";
                return false;
            }
            return true;
        }
        public static bool Validate(Computer computer)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(computer);
            if(!Validator.TryValidateObject(computer,context,results,true))
            {
                foreach(var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                MessageBox.Show("Все данные корректны");
                return true;
            }
        }
    }
    
}

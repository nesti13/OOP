using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.IO;



namespace lab10
{
    public class masters
    {
        public int id_master { get; set; }
        public int id_procedure { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string education { get; set; }
        public string qualification { get; set; }
        public int work_experience { get; set; }
        public BitmapImage photo { get; set; }
        public masters(int id_master, string surname, string name, string education, string qualification, int work_expirience, int id_procedure)
        {
            this.id_master = id_master;
            this.surname = surname;
            this.name = name;
            this.education = education;
            this.qualification = qualification;
            this.work_experience = work_expirience;
            this.id_procedure = id_procedure;

        }
        public masters(int id_master, string surname, string name, string education, string qualification, int work_expirience, int id_procedure, byte[] ImageBytes)
        {
            this.id_master = id_master;
            this.surname = surname;
            this.name = name;
            this.education = education;
            this.id_procedure = id_procedure;
            this.qualification = qualification;
            this.work_experience = work_expirience;
            Stream StreamObj = new MemoryStream(ImageBytes);
            photo = new BitmapImage();
            photo.BeginInit();
            photo.StreamSource = StreamObj;
            photo.EndInit();

        }

        public masters()
        {
        }
    }

    
}

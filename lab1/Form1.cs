using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    interface ICalc
    {
        void Result(TextBox твес, TextBox трост, TextBox твозраст, TextBox результат, ComboBox comboBox1, RadioButton мужпол, RadioButton женпол);
        void Clear(TextBox твес, TextBox трост, TextBox твозраст, TextBox результат, ComboBox comboBox1, RadioButton мужпол, RadioButton женпол);
    }
    public partial class Form1 : Form
    {
        public int  c, result2;
        public bool d, g;
        public bool error;
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }        

        private void Очистить_Click(object sender, EventArgs e)
        {
            calculator.Clear(this.твес, this.трост, this.твозраст, this.результат, this.comboBox1, this.мужпол, this.женпол);
        } 

        private void рассчитать_Click_1(object sender, EventArgs e)
        {
            calculator.Result(this.твес, this.трост, this.твозраст, this.результат, this.comboBox1, this.мужпол, this.женпол);
        }
    }
}
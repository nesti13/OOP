using System;
using System.Windows.Forms;

namespace lab1
{
    public class Calculator : ICalc
    {
        bool d, g;
        public int c, result2;
        public bool error;
        double a, result, b;
        public void Clear(TextBox твес, TextBox трост, TextBox твозраст, TextBox результат, ComboBox comboBox1, RadioButton мужпол, RadioButton женпол)
        {
            твес.Text = "";
            трост.Text = "";
            твозраст.Text = "";
            результат.Text = "";
            comboBox1.Text = "";
            мужпол.Checked = false;
            женпол.Checked = false;
        }

        public void Result(TextBox твес, TextBox трост, TextBox твозраст, TextBox результат, ComboBox comboBox1, RadioButton мужпол, RadioButton женпол)
        {
            d = женпол.Checked;
            g = мужпол.Checked;

            try
            {
                a = Convert.ToDouble(твес.Text);
            }
            catch (System.FormatException)
            {
                результат.Text = "Ошибка. Вы ввели неверный вес";
                error = true;
            }

            try
            {
                b = Convert.ToDouble(трост.Text);
            }
            catch (System.FormatException)
            {
                результат.Text = "Ошибка. Вы ввели неверный рост";
                error = true;
            }

            try
            {
                c = Convert.ToInt16(твозраст.Text);
            }
            catch (System.FormatException)
            {
                результат.Text = "Ошибка. Вы ввели неверный возраст";
                error = true;
            }

            if (d = true && error != true)
            {
                result = (int)(a / (b * b));

                if (result < 19)
                {
                    результат.Text = "ИМТ = " + result + ". Недостаток веса. Ваша суточная норма ккал равна 2359";
                }

                if (result > 19 && result < 25)
                {
                    результат.Text = "ИМТ = " + result + ". Нормальный ИМТ. Ваша суточная норма ккал равна 2243";
                }

                if (result > 25)
                {
                    результат.Text = "ИМТ = " + result + ". Имеется лишний вес. Ваша суточная норма ккал равна 2000";
                }
            }

            if (g = true && error != true)
            {
                result2 = (int)(a / (b * b));

                if (result2 < 18)
                {
                    результат.Text = "ИМТ = " + result + ". Недостаток веса. Ваша суточная норма ккал равна 2000";
                }

                if (result2 > 19 && result2 < 24)
                {
                    результат.Text = "ИМТ = " + result + ". Нормальный ИМТ. Ваша суточная норма ккал равна 1732";
                }

                if (result2 > 25)
                {
                    результат.Text = "ИМТ = " + result + ". Имеется лишний вес. Ваша суточная норма ккал равна 1328";
                }
            }

        }
    }
}

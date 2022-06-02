
using System;

namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.пол = new System.Windows.Forms.Label();
            this.вес = new System.Windows.Forms.Label();
            this.рост = new System.Windows.Forms.Label();
            this.возраст = new System.Windows.Forms.Label();
            this.цель = new System.Windows.Forms.Label();
            this.твес = new System.Windows.Forms.TextBox();
            this.трост = new System.Windows.Forms.TextBox();
            this.рассчитать = new System.Windows.Forms.Button();
            this.твозраст = new System.Windows.Forms.TextBox();
            this.результат = new System.Windows.Forms.TextBox();
            this.женпол = new System.Windows.Forms.RadioButton();
            this.мужпол = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Очистить = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // пол
            // 
            this.пол.AutoSize = true;
            this.пол.Location = new System.Drawing.Point(56, 9);
            this.пол.Name = "пол";
            this.пол.Size = new System.Drawing.Size(91, 17);
            this.пол.TabIndex = 1;
            this.пол.Text = "Введите пол";
            // 
            // вес
            // 
            this.вес.AutoSize = true;
            this.вес.Location = new System.Drawing.Point(56, 56);
            this.вес.Name = "вес";
            this.вес.Size = new System.Drawing.Size(146, 17);
            this.вес.TabIndex = 2;
            this.вес.Text = "Введите ваш вес в кг";
            // 
            // рост
            // 
            this.рост.AutoSize = true;
            this.рост.Location = new System.Drawing.Point(53, 101);
            this.рост.Name = "рост";
            this.рост.Size = new System.Drawing.Size(188, 17);
            this.рост.TabIndex = 3;
            this.рост.Text = "Введите ваш рост в метрах";
            // 
            // возраст
            // 
            this.возраст.AutoSize = true;
            this.возраст.Location = new System.Drawing.Point(53, 147);
            this.возраст.Name = "возраст";
            this.возраст.Size = new System.Drawing.Size(119, 17);
            this.возраст.TabIndex = 4;
            this.возраст.Text = "Введите возраст";
            // 
            // цель
            // 
            this.цель.AutoSize = true;
            this.цель.Location = new System.Drawing.Point(57, 192);
            this.цель.Name = "цель";
            this.цель.Size = new System.Drawing.Size(99, 17);
            this.цель.TabIndex = 5;
            this.цель.Text = "Укажите цель";
            // 
            // твес
            // 
            this.твес.Location = new System.Drawing.Point(55, 76);
            this.твес.Name = "твес";
            this.твес.Size = new System.Drawing.Size(100, 22);
            this.твес.TabIndex = 6;
            // 
            // трост
            // 
            this.трост.Location = new System.Drawing.Point(56, 122);
            this.трост.Name = "трост";
            this.трост.Size = new System.Drawing.Size(100, 22);
            this.трост.TabIndex = 7;
            // 
            // рассчитать
            // 
            this.рассчитать.Location = new System.Drawing.Point(235, 266);
            this.рассчитать.Name = "рассчитать";
            this.рассчитать.Size = new System.Drawing.Size(101, 29);
            this.рассчитать.TabIndex = 14;
            this.рассчитать.Text = "Рассчитать";
            this.рассчитать.UseVisualStyleBackColor = true;
            this.рассчитать.Click += new System.EventHandler(this.рассчитать_Click_1);
            // 
            // твозраст
            // 
            this.твозраст.Location = new System.Drawing.Point(56, 167);
            this.твозраст.Name = "твозраст";
            this.твозраст.Size = new System.Drawing.Size(100, 22);
            this.твозраст.TabIndex = 16;
            // 
            // результат
            // 
            this.результат.Location = new System.Drawing.Point(55, 318);
            this.результат.Name = "результат";
            this.результат.Size = new System.Drawing.Size(761, 22);
            this.результат.TabIndex = 18;
            // 
            // женпол
            // 
            this.женпол.AutoSize = true;
            this.женпол.Location = new System.Drawing.Point(158, 32);
            this.женпол.Name = "женпол";
            this.женпол.Size = new System.Drawing.Size(84, 21);
            this.женпол.TabIndex = 20;
            this.женпол.TabStop = true;
            this.женпол.Text = "женский";
            this.женпол.UseVisualStyleBackColor = true;
            // 
            // мужпол
            // 
            this.мужпол.AutoSize = true;
            this.мужпол.Location = new System.Drawing.Point(55, 32);
            this.мужпол.Name = "мужпол";
            this.мужпол.Size = new System.Drawing.Size(84, 21);
            this.мужпол.TabIndex = 21;
            this.мужпол.TabStop = true;
            this.мужпол.Text = "мужской";
            this.мужпол.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "поддержание веса и размеров",
            "снижение веса",
            "увеличение веса"});
            this.comboBox1.Location = new System.Drawing.Point(56, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // Очистить
            // 
            this.Очистить.Location = new System.Drawing.Point(342, 266);
            this.Очистить.Name = "Очистить";
            this.Очистить.Size = new System.Drawing.Size(101, 29);
            this.Очистить.TabIndex = 23;
            this.Очистить.Text = "Очистить";
            this.Очистить.UseVisualStyleBackColor = true;
            this.Очистить.Click += new System.EventHandler(this.Очистить_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 383);
            this.Controls.Add(this.Очистить);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.мужпол);
            this.Controls.Add(this.женпол);
            this.Controls.Add(this.результат);
            this.Controls.Add(this.твозраст);
            this.Controls.Add(this.рассчитать);
            this.Controls.Add(this.трост);
            this.Controls.Add(this.твес);
            this.Controls.Add(this.цель);
            this.Controls.Add(this.возраст);
            this.Controls.Add(this.рост);
            this.Controls.Add(this.вес);
            this.Controls.Add(this.пол);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label пол;
        private System.Windows.Forms.Label вес;
        private System.Windows.Forms.Label рост;
        private System.Windows.Forms.Label возраст;
        private System.Windows.Forms.Label цель;
        private System.Windows.Forms.TextBox твес;
        private System.Windows.Forms.TextBox трост;
        private System.Windows.Forms.Button рассчитать;
        private System.Windows.Forms.TextBox твозраст;
        private System.Windows.Forms.TextBox результат;
        private System.Windows.Forms.RadioButton женпол;
        private System.Windows.Forms.RadioButton мужпол;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Очистить;
    }
}


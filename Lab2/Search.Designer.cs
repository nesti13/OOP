
namespace Lab2
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular = new System.Windows.Forms.TextBox();
            this.search_name = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.search_type = new System.Windows.Forms.Label();
            this.regular_type = new System.Windows.Forms.TextBox();
            this.find2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.result.Location = new System.Drawing.Point(12, 165);
            this.result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RowHeadersWidth = 51;
            this.result.RowTemplate.Height = 25;
            this.result.Size = new System.Drawing.Size(1050, 305);
            this.result.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип компьютера";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Процессор";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Видеокарта";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Размер ОЗУ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Тип ОЗУ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Размер Диска";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Тип Диска";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата приобретения";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Regular
            // 
            this.Regular.Location = new System.Drawing.Point(21, 51);
            this.Regular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(227, 27);
            this.Regular.TabIndex = 30;
            this.Regular.TextChanged += new System.EventHandler(this.Regular_TextChanged);
            // 
            // search_name
            // 
            this.search_name.AutoSize = true;
            this.search_name.Location = new System.Drawing.Point(12, 18);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(223, 20);
            this.search_name.TabIndex = 31;
            this.search_name.Text = "Введите название процессора";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(12, 112);
            this.Find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(236, 31);
            this.Find.TabIndex = 32;
            this.Find.Text = "Найти процессор";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(525, 112);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 31);
            this.save.TabIndex = 33;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_type
            // 
            this.search_type.AutoSize = true;
            this.search_type.Location = new System.Drawing.Point(274, 18);
            this.search_type.Name = "search_type";
            this.search_type.Size = new System.Drawing.Size(184, 20);
            this.search_type.TabIndex = 34;
            this.search_type.Text = "Введите тип компьютера";
            // 
            // regular_type
            // 
            this.regular_type.Location = new System.Drawing.Point(274, 53);
            this.regular_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regular_type.Name = "regular_type";
            this.regular_type.Size = new System.Drawing.Size(227, 27);
            this.regular_type.TabIndex = 35;
            // 
            // find2
            // 
            this.find2.Location = new System.Drawing.Point(274, 112);
            this.find2.Name = "find2";
            this.find2.Size = new System.Drawing.Size(227, 31);
            this.find2.TabIndex = 36;
            this.find2.Text = "Найти тип компьютера";
            this.find2.UseVisualStyleBackColor = true;
            this.find2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 731);
            this.Controls.Add(this.find2);
            this.Controls.Add(this.regular_type);
            this.Controls.Add(this.search_type);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.search_name);
            this.Controls.Add(this.Regular);
            this.Controls.Add(this.result);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox Regular;
        private System.Windows.Forms.Label search_name;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label search_type;
        private System.Windows.Forms.TextBox regular_type;
        private System.Windows.Forms.Button find2;
    }
}
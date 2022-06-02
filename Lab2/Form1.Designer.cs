
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Computer_Type = new System.Windows.Forms.ComboBox();
            this.comp_type = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.TextBox();
            this.proc = new System.Windows.Forms.Label();
            this.Video_Name = new System.Windows.Forms.TextBox();
            this.vid_card = new System.Windows.Forms.Label();
            this.SizeOZU = new System.Windows.Forms.TextBox();
            this.ozu_value = new System.Windows.Forms.Label();
            this.ozu_type = new System.Windows.Forms.Label();
            this.Type_OZU = new System.Windows.Forms.ComboBox();
            this.SizeHD = new System.Windows.Forms.TextBox();
            this.disk_value = new System.Windows.Forms.Label();
            this.TypeHD = new System.Windows.Forms.ComboBox();
            this.disc_type = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.date_of_duty = new System.Windows.Forms.Label();
            this.ProcCount = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.Label();
            this.MemoryCount = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.Label();
            this.direct = new System.Windows.Forms.Label();
            this.DirectX = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерОЗУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерДискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.clone = new System.Windows.Forms.Button();
            this.builder = new System.Windows.Forms.Button();
            this.adapt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Computer_Type
            // 
            this.Computer_Type.FormattingEnabled = true;
            this.Computer_Type.Items.AddRange(new object[] {
            "Стационарный компьютер",
            "Ноутбук",
            "Сервер",
            "Рабочая станция"});
            this.Computer_Type.Location = new System.Drawing.Point(18, 65);
            this.Computer_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Computer_Type.Name = "Computer_Type";
            this.Computer_Type.Size = new System.Drawing.Size(125, 28);
            this.Computer_Type.TabIndex = 0;
            // 
            // comp_type
            // 
            this.comp_type.AutoSize = true;
            this.comp_type.Location = new System.Drawing.Point(18, 41);
            this.comp_type.Name = "comp_type";
            this.comp_type.Size = new System.Drawing.Size(126, 20);
            this.comp_type.TabIndex = 1;
            this.comp_type.Text = "Тип компьютера";
            // 
            // Processor
            // 
            this.Processor.Location = new System.Drawing.Point(18, 124);
            this.Processor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(125, 27);
            this.Processor.TabIndex = 2;
            // 
            // proc
            // 
            this.proc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proc.AutoSize = true;
            this.proc.Location = new System.Drawing.Point(18, 100);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(87, 20);
            this.proc.TabIndex = 3;
            this.proc.Text = "Процессор";
            // 
            // Video_Name
            // 
            this.Video_Name.Location = new System.Drawing.Point(331, 124);
            this.Video_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Video_Name.Name = "Video_Name";
            this.Video_Name.Size = new System.Drawing.Size(125, 27);
            this.Video_Name.TabIndex = 4;
            // 
            // vid_card
            // 
            this.vid_card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vid_card.AutoSize = true;
            this.vid_card.Location = new System.Drawing.Point(331, 100);
            this.vid_card.Name = "vid_card";
            this.vid_card.Size = new System.Drawing.Size(90, 20);
            this.vid_card.TabIndex = 5;
            this.vid_card.Text = "Видеокарта";
            // 
            // SizeOZU
            // 
            this.SizeOZU.Location = new System.Drawing.Point(492, 66);
            this.SizeOZU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeOZU.Name = "SizeOZU";
            this.SizeOZU.Size = new System.Drawing.Size(125, 27);
            this.SizeOZU.TabIndex = 6;
            // 
            // ozu_value
            // 
            this.ozu_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ozu_value.AutoSize = true;
            this.ozu_value.Location = new System.Drawing.Point(492, 41);
            this.ozu_value.Name = "ozu_value";
            this.ozu_value.Size = new System.Drawing.Size(122, 20);
            this.ozu_value.TabIndex = 7;
            this.ozu_value.Text = "Размер ОЗУ (ГБ)";
            // 
            // ozu_type
            // 
            this.ozu_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ozu_type.AutoSize = true;
            this.ozu_type.Location = new System.Drawing.Point(492, 97);
            this.ozu_type.Name = "ozu_type";
            this.ozu_type.Size = new System.Drawing.Size(67, 20);
            this.ozu_type.TabIndex = 8;
            this.ozu_type.Text = "Тип ОЗУ";
            // 
            // Type_OZU
            // 
            this.Type_OZU.FormattingEnabled = true;
            this.Type_OZU.Items.AddRange(new object[] {
            "DDR3",
            "DDR4"});
            this.Type_OZU.Location = new System.Drawing.Point(492, 124);
            this.Type_OZU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type_OZU.Name = "Type_OZU";
            this.Type_OZU.Size = new System.Drawing.Size(125, 28);
            this.Type_OZU.TabIndex = 9;
            // 
            // SizeHD
            // 
            this.SizeHD.Location = new System.Drawing.Point(650, 66);
            this.SizeHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeHD.Name = "SizeHD";
            this.SizeHD.Size = new System.Drawing.Size(125, 27);
            this.SizeHD.TabIndex = 10;
            // 
            // disk_value
            // 
            this.disk_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disk_value.AutoSize = true;
            this.disk_value.Location = new System.Drawing.Point(650, 41);
            this.disk_value.Name = "disk_value";
            this.disk_value.Size = new System.Drawing.Size(129, 20);
            this.disk_value.TabIndex = 11;
            this.disk_value.Text = "Размер диска(ГБ)";
            // 
            // TypeHD
            // 
            this.TypeHD.FormattingEnabled = true;
            this.TypeHD.Items.AddRange(new object[] {
            "HDD",
            "SSD"});
            this.TypeHD.Location = new System.Drawing.Point(650, 124);
            this.TypeHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeHD.Name = "TypeHD";
            this.TypeHD.Size = new System.Drawing.Size(125, 28);
            this.TypeHD.TabIndex = 12;
            // 
            // disc_type
            // 
            this.disc_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disc_type.AutoSize = true;
            this.disc_type.Location = new System.Drawing.Point(650, 100);
            this.disc_type.Name = "disc_type";
            this.disc_type.Size = new System.Drawing.Size(78, 20);
            this.disc_type.TabIndex = 13;
            this.disc_type.Text = "Тип диска";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(805, 66);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(147, 27);
            this.Date.TabIndex = 14;
            // 
            // date_of_duty
            // 
            this.date_of_duty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_of_duty.AutoSize = true;
            this.date_of_duty.Location = new System.Drawing.Point(805, 41);
            this.date_of_duty.Name = "date_of_duty";
            this.date_of_duty.Size = new System.Drawing.Size(147, 20);
            this.date_of_duty.TabIndex = 15;
            this.date_of_duty.Text = "Дата приобретения";
            // 
            // ProcCount
            // 
            this.ProcCount.FormattingEnabled = true;
            this.ProcCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ProcCount.Location = new System.Drawing.Point(176, 65);
            this.ProcCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProcCount.Name = "ProcCount";
            this.ProcCount.Size = new System.Drawing.Size(125, 28);
            this.ProcCount.TabIndex = 18;
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(176, 41);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(96, 20);
            this.quantity.TabIndex = 19;
            this.quantity.Text = "Кол-во Ядер";
            // 
            // MemoryCount
            // 
            this.MemoryCount.FormattingEnabled = true;
            this.MemoryCount.Items.AddRange(new object[] {
            "1 ГБ",
            "2 ГБ",
            "4 ГБ",
            "8 ГБ"});
            this.MemoryCount.Location = new System.Drawing.Point(176, 123);
            this.MemoryCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemoryCount.Name = "MemoryCount";
            this.MemoryCount.Size = new System.Drawing.Size(125, 28);
            this.MemoryCount.TabIndex = 20;
            // 
            // value
            // 
            this.value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(176, 100);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(112, 20);
            this.value.TabIndex = 21;
            this.value.Text = "Объем памяти";
            // 
            // direct
            // 
            this.direct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direct.AutoSize = true;
            this.direct.Location = new System.Drawing.Point(331, 41);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(58, 20);
            this.direct.TabIndex = 22;
            this.direct.Text = "DirectX";
            // 
            // DirectX
            // 
            this.DirectX.FormattingEnabled = true;
            this.DirectX.Items.AddRange(new object[] {
            "v. 9",
            "v. 10",
            "v. 11"});
            this.DirectX.Location = new System.Drawing.Point(331, 65);
            this.DirectX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DirectX.Name = "DirectX";
            this.DirectX.Size = new System.Drawing.Size(125, 28);
            this.DirectX.TabIndex = 23;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1133, 356);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(135, 31);
            this.Add.TabIndex = 24;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1133, 395);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(135, 31);
            this.Save.TabIndex = 25;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(1133, 434);
            this.Open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(135, 31);
            this.Open.TabIndex = 26;
            this.Open.Text = "Загрузить";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // result
            // 
            this.result.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.result.Location = new System.Drawing.Point(18, 175);
            this.result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RowHeadersWidth = 51;
            this.result.RowTemplate.Height = 25;
            this.result.Size = new System.Drawing.Size(1054, 291);
            this.result.TabIndex = 28;
            this.result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1320, 30);
            this.menu.TabIndex = 29;
            this.menu.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерОЗУToolStripMenuItem,
            this.размерДискаToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // размерОЗУToolStripMenuItem
            // 
            this.размерОЗУToolStripMenuItem.Name = "размерОЗУToolStripMenuItem";
            this.размерОЗУToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.размерОЗУToolStripMenuItem.Text = "Размер ОЗУ";
            this.размерОЗУToolStripMenuItem.Click += new System.EventHandler(this.размерОЗУToolStripMenuItem_Click);
            // 
            // размерДискаToolStripMenuItem
            // 
            this.размерДискаToolStripMenuItem.Name = "размерДискаToolStripMenuItem";
            this.размерДискаToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.размерДискаToolStripMenuItem.Text = "Размер Диска";
            this.размерДискаToolStripMenuItem.Click += new System.EventHandler(this.размерДискаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(637, 0);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(519, 27);
            this.Status.TabIndex = 30;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1320, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.Location = new System.Drawing.Point(398, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(34, 32);
            this.Back.TabIndex = 32;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Forward.BackgroundImage")));
            this.Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forward.Location = new System.Drawing.Point(439, 1);
            this.Forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(34, 31);
            this.Forward.TabIndex = 33;
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(1133, 209);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(135, 29);
            this.info.TabIndex = 34;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click_1);
            // 
            // clone
            // 
            this.clone.Location = new System.Drawing.Point(1133, 244);
            this.clone.Name = "clone";
            this.clone.Size = new System.Drawing.Size(135, 29);
            this.clone.TabIndex = 35;
            this.clone.Text = "Клонировать";
            this.clone.UseVisualStyleBackColor = true;
            this.clone.Click += new System.EventHandler(this.clone_Click);
            // 
            // builder
            // 
            this.builder.Location = new System.Drawing.Point(1133, 174);
            this.builder.Name = "builder";
            this.builder.Size = new System.Drawing.Size(135, 29);
            this.builder.TabIndex = 36;
            this.builder.Text = "Builder";
            this.builder.UseVisualStyleBackColor = true;
            this.builder.Click += new System.EventHandler(this.builder_Click);
            // 
            // adapt
            // 
            this.adapt.Location = new System.Drawing.Point(1133, 280);
            this.adapt.Name = "adapt";
            this.adapt.Size = new System.Drawing.Size(135, 29);
            this.adapt.TabIndex = 37;
            this.adapt.Text = "Adapter";
            this.adapt.UseVisualStyleBackColor = true;
            this.adapt.Click += new System.EventHandler(this.adapt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1320, 518);
            this.Controls.Add(this.adapt);
            this.Controls.Add(this.builder);
            this.Controls.Add(this.clone);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DirectX);
            this.Controls.Add(this.direct);
            this.Controls.Add(this.value);
            this.Controls.Add(this.MemoryCount);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.ProcCount);
            this.Controls.Add(this.date_of_duty);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.disc_type);
            this.Controls.Add(this.TypeHD);
            this.Controls.Add(this.disk_value);
            this.Controls.Add(this.SizeHD);
            this.Controls.Add(this.Type_OZU);
            this.Controls.Add(this.ozu_type);
            this.Controls.Add(this.ozu_value);
            this.Controls.Add(this.SizeOZU);
            this.Controls.Add(this.vid_card);
            this.Controls.Add(this.Video_Name);
            this.Controls.Add(this.proc);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.comp_type);
            this.Controls.Add(this.Computer_Type);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Computer_Type;
        private System.Windows.Forms.Label comp_type;
        private System.Windows.Forms.TextBox Processor;
        private System.Windows.Forms.Label proc;
        private System.Windows.Forms.TextBox Video_Name;
        private System.Windows.Forms.Label vid_card;
        private System.Windows.Forms.TextBox SizeOZU;
        private System.Windows.Forms.Label ozu_value;
        private System.Windows.Forms.Label ozu_type;
        private System.Windows.Forms.ComboBox Type_OZU;
        private System.Windows.Forms.TextBox SizeHD;
        private System.Windows.Forms.Label disk_value;
        private System.Windows.Forms.ComboBox TypeHD;
        private System.Windows.Forms.Label disc_type;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label date_of_duty;
        private System.Windows.Forms.ComboBox ProcCount;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.ComboBox MemoryCount;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label direct;
        private System.Windows.Forms.ComboBox DirectX;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерОЗУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерДискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button clone;
        private System.Windows.Forms.Button builder;
        private System.Windows.Forms.Button adapt;
    }
}


namespace ServerAvailability
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.gButSettings = new ServerAvailability.Controls.GBut();
            this.gButCondition = new ServerAvailability.Controls.GBut();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTimeLastUpdate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pageControl1 = new ServerAvailability.Controls.PageControl();
            this.tabPageCondition = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.gButAutoFind = new ServerAvailability.Controls.GBut();
            this.gButAddbyHand = new ServerAvailability.Controls.GBut();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.gButSettings);
            this.panel1.Controls.Add(this.gButCondition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 603);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приоритеты";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 22);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(149, 35);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00:00";
            // 
            // gButSettings
            // 
            this.gButSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButSettings.BORDER = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.gButSettings.DOWN = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(235)))), ((int)(((byte)(151)))));
            this.gButSettings.ENTER = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(189)))), ((int)(((byte)(106)))));
            this.gButSettings.hRound = 3;
            this.gButSettings.Location = new System.Drawing.Point(12, 199);
            this.gButSettings.Name = "gButSettings";
            this.gButSettings.NORMAL = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButSettings.Size = new System.Drawing.Size(161, 52);
            this.gButSettings.TabIndex = 1;
            this.gButSettings.Text = "Настройка";
            this.gButSettings.wRound = 3;
            this.gButSettings.Click += new System.EventHandler(this.gButSettings_Click);
            // 
            // gButCondition
            // 
            this.gButCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButCondition.BORDER = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.gButCondition.DOWN = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(235)))), ((int)(((byte)(151)))));
            this.gButCondition.ENTER = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(189)))), ((int)(((byte)(106)))));
            this.gButCondition.hRound = 3;
            this.gButCondition.Location = new System.Drawing.Point(12, 141);
            this.gButCondition.Name = "gButCondition";
            this.gButCondition.NORMAL = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButCondition.Size = new System.Drawing.Size(161, 52);
            this.gButCondition.TabIndex = 0;
            this.gButCondition.Text = "Состояние";
            this.gButCondition.wRound = 3;
            this.gButCondition.Click += new System.EventHandler(this.gButCondition_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelTimeLastUpdate);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.pageControl1);
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 603);
            this.panel2.TabIndex = 1;
            // 
            // labelTimeLastUpdate
            // 
            this.labelTimeLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeLastUpdate.AutoSize = true;
            this.labelTimeLastUpdate.BackColor = System.Drawing.Color.Azure;
            this.labelTimeLastUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeLastUpdate.Location = new System.Drawing.Point(567, 9);
            this.labelTimeLastUpdate.Name = "labelTimeLastUpdate";
            this.labelTimeLastUpdate.Size = new System.Drawing.Size(299, 22);
            this.labelTimeLastUpdate.TabIndex = 1;
            this.labelTimeLastUpdate.Text = "Последнее обновление 00:00:00";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(460, 577);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(421, 22);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Подключён к сети";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pageControl1
            // 
            this.pageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl1.Controls.Add(this.tabPageCondition);
            this.pageControl1.Controls.Add(this.tabPageSettings);
            this.pageControl1.Location = new System.Drawing.Point(0, 22);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.SelectedIndex = 0;
            this.pageControl1.Size = new System.Drawing.Size(893, 556);
            this.pageControl1.TabIndex = 0;
            // 
            // tabPageCondition
            // 
            this.tabPageCondition.AutoScroll = true;
            this.tabPageCondition.BackColor = System.Drawing.Color.Azure;
            this.tabPageCondition.Location = new System.Drawing.Point(4, 22);
            this.tabPageCondition.Name = "tabPageCondition";
            this.tabPageCondition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCondition.Size = new System.Drawing.Size(885, 530);
            this.tabPageCondition.TabIndex = 0;
            this.tabPageCondition.Text = "tabPageCondition";
            this.tabPageCondition.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tabPageCondition_Scroll);
            this.tabPageCondition.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageCondition_Paint);
            this.tabPageCondition.Resize += new System.EventHandler(this.tabPageCondition_Resize);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.gButAutoFind);
            this.tabPageSettings.Controls.Add(this.gButAddbyHand);
            this.tabPageSettings.Controls.Add(this.listView1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(885, 530);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "tabPageSettings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // gButAutoFind
            // 
            this.gButAutoFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAutoFind.BORDER = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.gButAutoFind.DOWN = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(235)))), ((int)(((byte)(151)))));
            this.gButAutoFind.ENTER = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(189)))), ((int)(((byte)(106)))));
            this.gButAutoFind.hRound = 3;
            this.gButAutoFind.Location = new System.Drawing.Point(460, 113);
            this.gButAutoFind.Name = "gButAutoFind";
            this.gButAutoFind.NORMAL = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAutoFind.Size = new System.Drawing.Size(185, 36);
            this.gButAutoFind.TabIndex = 3;
            this.gButAutoFind.Text = "Автоматический поиск";
            this.gButAutoFind.wRound = 3;
            this.gButAutoFind.Click += new System.EventHandler(this.gButAutoFind_Click);
            // 
            // gButAddbyHand
            // 
            this.gButAddbyHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAddbyHand.BORDER = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.gButAddbyHand.DOWN = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(235)))), ((int)(((byte)(151)))));
            this.gButAddbyHand.ENTER = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(189)))), ((int)(((byte)(106)))));
            this.gButAddbyHand.hRound = 3;
            this.gButAddbyHand.Location = new System.Drawing.Point(460, 66);
            this.gButAddbyHand.Name = "gButAddbyHand";
            this.gButAddbyHand.NORMAL = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAddbyHand.Size = new System.Drawing.Size(185, 36);
            this.gButAddbyHand.TabIndex = 2;
            this.gButAddbyHand.Text = "Добавить вручную";
            this.gButAddbyHand.wRound = 3;
            this.gButAddbyHand.Click += new System.EventHandler(this.gButAddbyHand_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(71, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 163);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование сервера";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP-адрес";
            this.columnHeader2.Width = 120;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг серверов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pageControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ServerAvailability.Controls.PageControl pageControl1;
        private System.Windows.Forms.TabPage tabPageCondition;
        private System.Windows.Forms.TabPage tabPageSettings;
        private ServerAvailability.Controls.GBut gButCondition;
        private ServerAvailability.Controls.GBut gButSettings;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Controls.GBut gButAddbyHand;
        private Controls.GBut gButAutoFind;
        private System.Windows.Forms.Label labelTimeLastUpdate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}


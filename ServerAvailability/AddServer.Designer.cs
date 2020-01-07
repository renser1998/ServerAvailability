namespace ServerAvailability
{
    partial class AddServer
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxNameServ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gButAdd = new ServerAvailability.Controls.GBut();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP.Location = new System.Drawing.Point(85, 231);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(229, 29);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNameServ
            // 
            this.textBoxNameServ.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameServ.Location = new System.Drawing.Point(85, 37);
            this.textBoxNameServ.Name = "textBoxNameServ";
            this.textBoxNameServ.Size = new System.Drawing.Size(229, 29);
            this.textBoxNameServ.TabIndex = 2;
            this.textBoxNameServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование сервера";
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.BackColor = System.Drawing.Color.White;
            this.comboBoxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKind.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Items.AddRange(new object[] {
            "Сервер",
            "Ноутбук",
            "Компьютер",
            "Роутер",
            "Коммутатор",
            "Телефон"});
            this.comboBoxKind.Location = new System.Drawing.Point(85, 167);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(229, 31);
            this.comboBoxKind.TabIndex = 5;
            // 
            // textBoxFio
            // 
            this.textBoxFio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFio.Location = new System.Drawing.Point(85, 104);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(229, 29);
            this.textBoxFio.TabIndex = 7;
            this.textBoxFio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "ФИО пользователя";
            // 
            // gButAdd
            // 
            this.gButAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAdd.BORDER = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.gButAdd.DOWN = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(235)))), ((int)(((byte)(151)))));
            this.gButAdd.ENTER = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(189)))), ((int)(((byte)(106)))));
            this.gButAdd.hRound = 3;
            this.gButAdd.Location = new System.Drawing.Point(122, 343);
            this.gButAdd.Name = "gButAdd";
            this.gButAdd.NORMAL = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.gButAdd.Size = new System.Drawing.Size(131, 35);
            this.gButAdd.TabIndex = 0;
            this.gButAdd.Text = "Добавить";
            this.gButAdd.wRound = 3;
            this.gButAdd.Click += new System.EventHandler(this.gButAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Приоритет работы";
            // 
            // comboBoxProir
            // 
            this.comboBoxProir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProir.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.comboBoxProir.FormattingEnabled = true;
            this.comboBoxProir.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboBoxProir.Location = new System.Drawing.Point(85, 288);
            this.comboBoxProir.Name = "comboBoxProir";
            this.comboBoxProir.Size = new System.Drawing.Size(229, 31);
            this.comboBoxProir.TabIndex = 11;
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.comboBoxKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameServ);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.gButAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вручную";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.GBut gButAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBoxIP;
        internal System.Windows.Forms.TextBox textBoxNameServ;
        internal System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox comboBoxProir;
    }
}
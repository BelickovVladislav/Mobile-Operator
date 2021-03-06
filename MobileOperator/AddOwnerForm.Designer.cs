﻿namespace MobileOperator
{
    partial class AddOwnerForm
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
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.ComboBox();
            this.AddPhoneBtn = new System.Windows.Forms.Button();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.TariffLbl = new System.Windows.Forms.Label();
            this.AddTariffBtn = new System.Windows.Forms.Button();
            this.TariffBox = new System.Windows.Forms.ComboBox();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.ServiceLstUse = new System.Windows.Forms.ListBox();
            this.ServiceLstUnuse = new System.Windows.Forms.ListBox();
            this.SexLbl = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.PassportBox = new System.Windows.Forms.TextBox();
            this.PassportLbl = new System.Windows.Forms.Label();
            this.NumberPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.NumberPhoneLbl = new System.Windows.Forms.Label();
            this.PhotoUploadBtn = new System.Windows.Forms.Button();
            this.PhotoLbl = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.AddOwnerBtn = new System.Windows.Forms.Button();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.MiddleNameLbl = new System.Windows.Forms.Label();
            this.resultPriceBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.resultPriceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(11, 31);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(131, 20);
            this.SurnameBox.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(170, 31);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(131, 20);
            this.FirstNameBox.TabIndex = 1;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(325, 31);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(131, 20);
            this.MiddleNameBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(170, 69);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(131, 21);
            this.PhoneBox.TabIndex = 3;
            // 
            // AddPhoneBtn
            // 
            this.AddPhoneBtn.Location = new System.Drawing.Point(328, 69);
            this.AddPhoneBtn.Name = "AddPhoneBtn";
            this.AddPhoneBtn.Size = new System.Drawing.Size(131, 23);
            this.AddPhoneBtn.TabIndex = 4;
            this.AddPhoneBtn.Text = "Добавить телефон";
            this.AddPhoneBtn.UseVisualStyleBackColor = true;
            this.AddPhoneBtn.Click += new System.EventHandler(this.AddPhoneBtn_Click);
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(11, 69);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(52, 13);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Телефон";
            // 
            // TariffLbl
            // 
            this.TariffLbl.AutoSize = true;
            this.TariffLbl.Location = new System.Drawing.Point(12, 116);
            this.TariffLbl.Name = "TariffLbl";
            this.TariffLbl.Size = new System.Drawing.Size(40, 13);
            this.TariffLbl.TabIndex = 8;
            this.TariffLbl.Text = "Тариф";
            // 
            // AddTariffBtn
            // 
            this.AddTariffBtn.Location = new System.Drawing.Point(165, 23);
            this.AddTariffBtn.Name = "AddTariffBtn";
            this.AddTariffBtn.Size = new System.Drawing.Size(131, 23);
            this.AddTariffBtn.TabIndex = 7;
            this.AddTariffBtn.Text = "Добавить тариф";
            this.AddTariffBtn.UseVisualStyleBackColor = true;
            this.AddTariffBtn.Click += new System.EventHandler(this.AddTariffBtn_Click);
            // 
            // TariffBox
            // 
            this.TariffBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TariffBox.FormattingEnabled = true;
            this.TariffBox.Location = new System.Drawing.Point(170, 130);
            this.TariffBox.Name = "TariffBox";
            this.TariffBox.Size = new System.Drawing.Size(131, 21);
            this.TariffBox.TabIndex = 6;
            this.TariffBox.SelectedIndexChanged += new System.EventHandler(this.TariffBox_SelectedIndexChanged);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Location = new System.Drawing.Point(12, 165);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(67, 13);
            this.ServiceLbl.TabIndex = 18;
            this.ServiceLbl.Text = "Доп. услуги";
            // 
            // ServiceLstUse
            // 
            this.ServiceLstUse.FormattingEnabled = true;
            this.ServiceLstUse.Location = new System.Drawing.Point(328, 165);
            this.ServiceLstUse.Name = "ServiceLstUse";
            this.ServiceLstUse.Size = new System.Drawing.Size(131, 95);
            this.ServiceLstUse.TabIndex = 17;
            this.ServiceLstUse.Click += new System.EventHandler(this.ServiceLstUse_Click);
            this.ServiceLstUse.SelectedIndexChanged += new System.EventHandler(this.TariffBox_SelectedIndexChanged);
            // 
            // ServiceLstUnuse
            // 
            this.ServiceLstUnuse.FormattingEnabled = true;
            this.ServiceLstUnuse.Location = new System.Drawing.Point(170, 165);
            this.ServiceLstUnuse.Name = "ServiceLstUnuse";
            this.ServiceLstUnuse.Size = new System.Drawing.Size(131, 95);
            this.ServiceLstUnuse.TabIndex = 16;
            this.ServiceLstUnuse.Click += new System.EventHandler(this.ServiceLstUnuse_Click);
            this.ServiceLstUnuse.SelectedIndexChanged += new System.EventHandler(this.TariffBox_SelectedIndexChanged);
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Location = new System.Drawing.Point(8, 282);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(27, 13);
            this.SexLbl.TabIndex = 20;
            this.SexLbl.Text = "Пол";
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.SexBox.Location = new System.Drawing.Point(170, 282);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(131, 21);
            this.SexBox.TabIndex = 19;
            // 
            // PassportBox
            // 
            this.PassportBox.Location = new System.Drawing.Point(170, 332);
            this.PassportBox.Name = "PassportBox";
            this.PassportBox.Size = new System.Drawing.Size(131, 20);
            this.PassportBox.TabIndex = 21;
            // 
            // PassportLbl
            // 
            this.PassportLbl.AutoSize = true;
            this.PassportLbl.Location = new System.Drawing.Point(8, 332);
            this.PassportLbl.Name = "PassportLbl";
            this.PassportLbl.Size = new System.Drawing.Size(91, 13);
            this.PassportLbl.TabIndex = 22;
            this.PassportLbl.Text = "Номер паспорта";
            // 
            // NumberPhoneBox
            // 
            this.NumberPhoneBox.Location = new System.Drawing.Point(170, 380);
            this.NumberPhoneBox.Name = "NumberPhoneBox";
            this.NumberPhoneBox.Size = new System.Drawing.Size(131, 20);
            this.NumberPhoneBox.TabIndex = 23;
            // 
            // NumberPhoneLbl
            // 
            this.NumberPhoneLbl.AutoSize = true;
            this.NumberPhoneLbl.Location = new System.Drawing.Point(8, 380);
            this.NumberPhoneLbl.Name = "NumberPhoneLbl";
            this.NumberPhoneLbl.Size = new System.Drawing.Size(93, 13);
            this.NumberPhoneLbl.TabIndex = 24;
            this.NumberPhoneLbl.Text = "Номер телефона";
            // 
            // PhotoUploadBtn
            // 
            this.PhotoUploadBtn.Location = new System.Drawing.Point(170, 429);
            this.PhotoUploadBtn.Name = "PhotoUploadBtn";
            this.PhotoUploadBtn.Size = new System.Drawing.Size(131, 23);
            this.PhotoUploadBtn.TabIndex = 25;
            this.PhotoUploadBtn.Text = "Загрузить фото";
            this.PhotoUploadBtn.UseVisualStyleBackColor = true;
            this.PhotoUploadBtn.Click += new System.EventHandler(this.PhotoUploadBtn_Click);
            // 
            // PhotoLbl
            // 
            this.PhotoLbl.AutoSize = true;
            this.PhotoLbl.Location = new System.Drawing.Point(11, 429);
            this.PhotoLbl.Name = "PhotoLbl";
            this.PhotoLbl.Size = new System.Drawing.Size(35, 13);
            this.PhotoLbl.TabIndex = 26;
            this.PhotoLbl.Text = "Фото";
            // 
            // PhotoBox
            // 
            this.PhotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhotoBox.Location = new System.Drawing.Point(325, 332);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(131, 119);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 27;
            this.PhotoBox.TabStop = false;
            // 
            // AddOwnerBtn
            // 
            this.AddOwnerBtn.Location = new System.Drawing.Point(11, 471);
            this.AddOwnerBtn.Name = "AddOwnerBtn";
            this.AddOwnerBtn.Size = new System.Drawing.Size(455, 23);
            this.AddOwnerBtn.TabIndex = 28;
            this.AddOwnerBtn.Text = "Добавить клиента";
            this.AddOwnerBtn.UseVisualStyleBackColor = true;
            this.AddOwnerBtn.Click += new System.EventHandler(this.AddOwnerBtn_Click);
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(11, 12);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(56, 13);
            this.SurnameLbl.TabIndex = 29;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(167, 9);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLbl.TabIndex = 30;
            this.FirstNameLbl.Text = "Имя";
            // 
            // MiddleNameLbl
            // 
            this.MiddleNameLbl.AutoSize = true;
            this.MiddleNameLbl.Location = new System.Drawing.Point(325, 12);
            this.MiddleNameLbl.Name = "MiddleNameLbl";
            this.MiddleNameLbl.Size = new System.Drawing.Size(54, 13);
            this.MiddleNameLbl.TabIndex = 31;
            this.MiddleNameLbl.Text = "Отчество";
            // 
            // resultPriceBox
            // 
            this.resultPriceBox.Controls.Add(this.AddTariffBtn);
            this.resultPriceBox.Location = new System.Drawing.Point(162, 107);
            this.resultPriceBox.Name = "resultPriceBox";
            this.resultPriceBox.Size = new System.Drawing.Size(304, 167);
            this.resultPriceBox.TabIndex = 32;
            this.resultPriceBox.TabStop = false;
            this.resultPriceBox.Text = "Ежемесячная плата: 0 руб.";
            // 
            // AddOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 508);
            this.Controls.Add(this.MiddleNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.AddOwnerBtn);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.PhotoLbl);
            this.Controls.Add(this.PhotoUploadBtn);
            this.Controls.Add(this.NumberPhoneLbl);
            this.Controls.Add(this.NumberPhoneBox);
            this.Controls.Add(this.PassportLbl);
            this.Controls.Add(this.PassportBox);
            this.Controls.Add(this.SexLbl);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.ServiceLbl);
            this.Controls.Add(this.ServiceLstUse);
            this.Controls.Add(this.ServiceLstUnuse);
            this.Controls.Add(this.TariffLbl);
            this.Controls.Add(this.TariffBox);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.AddPhoneBtn);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.resultPriceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOwnerForm";
            this.Text = "Добавить клиента";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.resultPriceBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.ComboBox PhoneBox;
        private System.Windows.Forms.Button AddPhoneBtn;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label TariffLbl;
        private System.Windows.Forms.Button AddTariffBtn;
        private System.Windows.Forms.ComboBox TariffBox;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.ListBox ServiceLstUse;
        private System.Windows.Forms.ListBox ServiceLstUnuse;
        private System.Windows.Forms.Label SexLbl;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.TextBox PassportBox;
        private System.Windows.Forms.Label PassportLbl;
        private System.Windows.Forms.MaskedTextBox NumberPhoneBox;
        private System.Windows.Forms.Label NumberPhoneLbl;
        private System.Windows.Forms.Button PhotoUploadBtn;
        private System.Windows.Forms.Label PhotoLbl;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Button AddOwnerBtn;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label MiddleNameLbl;
        private System.Windows.Forms.GroupBox resultPriceBox;
    }
}
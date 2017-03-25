namespace MobileOperator
{
    partial class AddTariffForm
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
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ServiceLstUnuse = new System.Windows.Forms.ListBox();
            this.ServiceLstUse = new System.Windows.Forms.ListBox();
            this.AddService = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(68, 54);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(246, 72);
            this.DescriptionBox.TabIndex = 8;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(68, 16);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(246, 20);
            this.NameBox.TabIndex = 7;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 54);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(57, 13);
            this.DescriptionLbl.TabIndex = 6;
            this.DescriptionLbl.Text = "Описание";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(7, 16);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(57, 13);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Название";
            // 
            // ServiceLstUnuse
            // 
            this.ServiceLstUnuse.FormattingEnabled = true;
            this.ServiceLstUnuse.Location = new System.Drawing.Point(68, 132);
            this.ServiceLstUnuse.Name = "ServiceLstUnuse";
            this.ServiceLstUnuse.Size = new System.Drawing.Size(120, 95);
            this.ServiceLstUnuse.TabIndex = 9;
            // 
            // ServiceLstUse
            // 
            this.ServiceLstUse.FormattingEnabled = true;
            this.ServiceLstUse.Location = new System.Drawing.Point(194, 132);
            this.ServiceLstUse.Name = "ServiceLstUse";
            this.ServiceLstUse.Size = new System.Drawing.Size(120, 95);
            this.ServiceLstUse.TabIndex = 10;
            // 
            // AddService
            // 
            this.AddService.Location = new System.Drawing.Point(68, 233);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(120, 23);
            this.AddService.TabIndex = 11;
            this.AddService.Text = "Добавить услугу";
            this.AddService.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(10, 312);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(304, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(68, 271);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(246, 20);
            this.PriceBox.TabIndex = 13;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(7, 271);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(33, 13);
            this.PriceLbl.TabIndex = 12;
            this.PriceLbl.Text = "Цена";
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Location = new System.Drawing.Point(10, 132);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(43, 13);
            this.ServiceLbl.TabIndex = 15;
            this.ServiceLbl.Text = "Услуги";
            // 
            // AddTariffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 348);
            this.Controls.Add(this.ServiceLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.AddService);
            this.Controls.Add(this.ServiceLstUse);
            this.Controls.Add(this.ServiceLstUnuse);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.NameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTariffForm";
            this.Text = "Добавить тариф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ListBox ServiceLstUnuse;
        private System.Windows.Forms.ListBox ServiceLstUse;
        private System.Windows.Forms.Button AddService;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label ServiceLbl;
    }
}
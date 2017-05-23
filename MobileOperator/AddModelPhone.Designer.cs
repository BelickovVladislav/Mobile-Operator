namespace MobileOperator
{
    partial class AddModelPhone
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
            this.ProducerBox = new System.Windows.Forms.ComboBox();
            this.AddProducerBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ProducerLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProducerBox
            // 
            this.ProducerBox.FormattingEnabled = true;
            this.ProducerBox.Location = new System.Drawing.Point(104, 34);
            this.ProducerBox.Name = "ProducerBox";
            this.ProducerBox.Size = new System.Drawing.Size(121, 21);
            this.ProducerBox.TabIndex = 0;
            // 
            // AddProducerBtn
            // 
            this.AddProducerBtn.Location = new System.Drawing.Point(242, 34);
            this.AddProducerBtn.Name = "AddProducerBtn";
            this.AddProducerBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProducerBtn.TabIndex = 1;
            this.AddProducerBtn.Text = "Добавить";
            this.AddProducerBtn.UseVisualStyleBackColor = true;
            this.AddProducerBtn.Click += new System.EventHandler(this.AddProducerBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(104, 87);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(69, 157);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(219, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Добавить модель";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProducerLbl
            // 
            this.ProducerLbl.AutoSize = true;
            this.ProducerLbl.Location = new System.Drawing.Point(12, 37);
            this.ProducerLbl.Name = "ProducerLbl";
            this.ProducerLbl.Size = new System.Drawing.Size(86, 13);
            this.ProducerLbl.TabIndex = 4;
            this.ProducerLbl.Text = "Производитель";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 90);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(57, 13);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Название";
            // 
            // AddModelPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 215);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ProducerLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddProducerBtn);
            this.Controls.Add(this.ProducerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModelPhone";
            this.Text = "Добавить модель телефона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProducerBox;
        private System.Windows.Forms.Button AddProducerBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ProducerLbl;
        private System.Windows.Forms.Label NameLbl;
    }
}
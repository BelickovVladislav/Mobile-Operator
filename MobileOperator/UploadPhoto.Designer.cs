namespace MobileOperator
{
    partial class UploadPhotoForm
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
            this.Upload = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(46, 111);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(101, 51);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Сохранить";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(46, 57);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(313, 20);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Text = "Укажите ссылку на файл";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(258, 111);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 51);
            this.Save.TabIndex = 2;
            this.Save.Text = "Загрузить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите ссылку на файл:";
            // 
            // UploadPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.Upload);
            this.Name = "UploadPhotoForm";
            this.Text = "Загрузка фото";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        public System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
    }
}
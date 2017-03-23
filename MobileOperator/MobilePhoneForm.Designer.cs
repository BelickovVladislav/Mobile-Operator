namespace MobileOperator
{
    partial class MobilePhoneForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MobilePhoneView = new System.Windows.Forms.DataGridView();
            this.ModelPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MobilePhoneView)).BeginInit();
            this.SuspendLayout();
            // 
            // MobilePhoneView
            // 
            this.MobilePhoneView.AllowUserToAddRows = false;
            this.MobilePhoneView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MobilePhoneView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MobilePhoneView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MobilePhoneView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelPhone,
            this.OS,
            this.info});
            this.MobilePhoneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MobilePhoneView.EnableHeadersVisualStyles = false;
            this.MobilePhoneView.Location = new System.Drawing.Point(0, 0);
            this.MobilePhoneView.Name = "MobilePhoneView";
            this.MobilePhoneView.ReadOnly = true;
            this.MobilePhoneView.RowHeadersVisible = false;
            this.MobilePhoneView.Size = new System.Drawing.Size(499, 345);
            this.MobilePhoneView.TabIndex = 1;
            // 
            // ModelPhone
            // 
            this.ModelPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelPhone.HeaderText = "Модель телефона";
            this.ModelPhone.Name = "ModelPhone";
            this.ModelPhone.ReadOnly = true;
            // 
            // OS
            // 
            this.OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS.HeaderText = "Операционная система";
            this.OS.Name = "OS";
            this.OS.ReadOnly = true;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.HeaderText = "";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // MobilePhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 345);
            this.Controls.Add(this.MobilePhoneView);
            this.Name = "MobilePhoneForm";
            this.Text = "Мобильный телефон";
            ((System.ComponentModel.ISupportInitialize)(this.MobilePhoneView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MobilePhoneView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewButtonColumn info;
    }
}
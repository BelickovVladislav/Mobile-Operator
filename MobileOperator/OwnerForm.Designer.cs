namespace MobileOperator
{
    partial class OwnerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OwnerView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerView)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerView
            // 
            this.OwnerView.AllowUserToAddRows = false;
            this.OwnerView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OwnerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.PhoneNumber,
            this.passport_data,
            this.info});
            this.OwnerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OwnerView.EnableHeadersVisualStyles = false;
            this.OwnerView.Location = new System.Drawing.Point(0, 0);
            this.OwnerView.Name = "OwnerView";
            this.OwnerView.ReadOnly = true;
            this.OwnerView.RowHeadersVisible = false;
            this.OwnerView.Size = new System.Drawing.Size(725, 287);
            this.OwnerView.TabIndex = 0;
            this.OwnerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OwnerView_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 20;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fio.FillWeight = 140.2597F;
            this.fio.HeaderText = "Фамилия Имя Отчество";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.FillWeight = 140.2597F;
            this.PhoneNumber.HeaderText = "Номер телефона";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // passport_data
            // 
            this.passport_data.HeaderText = "Номер паспорта";
            this.passport_data.Name = "passport_data";
            this.passport_data.ReadOnly = true;
            this.passport_data.Width = 150;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.FillWeight = 19.48052F;
            this.info.HeaderText = "";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 287);
            this.Controls.Add(this.OwnerView);
            this.Name = "OwnerForm";
            this.Text = "Мобильный оператор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerForm_FormClosing);
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OwnerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OwnerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_data;
        private System.Windows.Forms.DataGridViewButtonColumn info;
    }
}


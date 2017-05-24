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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OwnerView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOwnerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.мобильныйТелефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMobilePhoneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProducerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPhoneTypeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddModelPhoneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTarifMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddServiceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OwnerView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OwnerView
            // 
            this.OwnerView.AllowUserToAddRows = false;
            this.OwnerView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OwnerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.PhoneNumber,
            this.passport_data,
            this.info});
            this.OwnerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OwnerView.EnableHeadersVisualStyles = false;
            this.OwnerView.Location = new System.Drawing.Point(0, 24);
            this.OwnerView.Name = "OwnerView";
            this.OwnerView.ReadOnly = true;
            this.OwnerView.RowHeadersVisible = false;
            this.OwnerView.Size = new System.Drawing.Size(725, 263);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOwnerMenu,
            this.мобильныйТелефонToolStripMenuItem,
            this.тарифToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // AddOwnerMenu
            // 
            this.AddOwnerMenu.Name = "AddOwnerMenu";
            this.AddOwnerMenu.Size = new System.Drawing.Size(192, 22);
            this.AddOwnerMenu.Text = "Добавить клиента";
            this.AddOwnerMenu.Click += new System.EventHandler(this.AddOwnerMenu_Click);
            // 
            // мобильныйТелефонToolStripMenuItem
            // 
            this.мобильныйТелефонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMobilePhoneMenu,
            this.AddProducerMenu,
            this.AddPhoneTypeMenu,
            this.AddOSMenu,
            this.AddModelPhoneMenu});
            this.мобильныйТелефонToolStripMenuItem.Name = "мобильныйТелефонToolStripMenuItem";
            this.мобильныйТелефонToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.мобильныйТелефонToolStripMenuItem.Text = "Мобильный телефон";
            // 
            // AddMobilePhoneMenu
            // 
            this.AddMobilePhoneMenu.Name = "AddMobilePhoneMenu";
            this.AddMobilePhoneMenu.Size = new System.Drawing.Size(212, 22);
            this.AddMobilePhoneMenu.Text = "Добавить телефон";
            this.AddMobilePhoneMenu.Click += new System.EventHandler(this.AddMobilePhoneMenu_Click);
            // 
            // AddProducerMenu
            // 
            this.AddProducerMenu.Name = "AddProducerMenu";
            this.AddProducerMenu.Size = new System.Drawing.Size(212, 22);
            this.AddProducerMenu.Text = "Добавить производителя";
            this.AddProducerMenu.Click += new System.EventHandler(this.AddProducerMenu_Click);
            // 
            // AddPhoneTypeMenu
            // 
            this.AddPhoneTypeMenu.Name = "AddPhoneTypeMenu";
            this.AddPhoneTypeMenu.Size = new System.Drawing.Size(212, 22);
            this.AddPhoneTypeMenu.Text = "Добавить тип";
            this.AddPhoneTypeMenu.Click += new System.EventHandler(this.AddPhoneTypeMenu_Click);
            // 
            // AddOSMenu
            // 
            this.AddOSMenu.Name = "AddOSMenu";
            this.AddOSMenu.Size = new System.Drawing.Size(212, 22);
            this.AddOSMenu.Text = "Добавить ОС";
            this.AddOSMenu.Click += new System.EventHandler(this.AddOSMenu_Click);
            // 
            // AddModelPhoneMenu
            // 
            this.AddModelPhoneMenu.Name = "AddModelPhoneMenu";
            this.AddModelPhoneMenu.Size = new System.Drawing.Size(212, 22);
            this.AddModelPhoneMenu.Text = "Добавить модель";
            this.AddModelPhoneMenu.Click += new System.EventHandler(this.AddModelPhoneMenu_Click);
            // 
            // тарифToolStripMenuItem
            // 
            this.тарифToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTarifMenu,
            this.AddServiceMenu});
            this.тарифToolStripMenuItem.Name = "тарифToolStripMenuItem";
            this.тарифToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.тарифToolStripMenuItem.Text = "Тариф";
            // 
            // AddTarifMenu
            // 
            this.AddTarifMenu.Name = "AddTarifMenu";
            this.AddTarifMenu.Size = new System.Drawing.Size(165, 22);
            this.AddTarifMenu.Text = "Добавить тариф";
            this.AddTarifMenu.Click += new System.EventHandler(this.AddTarifMenu_Click);
            // 
            // AddServiceMenu
            // 
            this.AddServiceMenu.Name = "AddServiceMenu";
            this.AddServiceMenu.Size = new System.Drawing.Size(165, 22);
            this.AddServiceMenu.Text = "Добавить услугу";
            this.AddServiceMenu.Click += new System.EventHandler(this.AddServiceMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 287);
            this.Controls.Add(this.OwnerView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OwnerForm";
            this.Text = "Мобильный оператор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerForm_FormClosing);
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OwnerView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OwnerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_data;
        private System.Windows.Forms.DataGridViewButtonColumn info;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOwnerMenu;
        private System.Windows.Forms.ToolStripMenuItem мобильныйТелефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMobilePhoneMenu;
        private System.Windows.Forms.ToolStripMenuItem AddProducerMenu;
        private System.Windows.Forms.ToolStripMenuItem AddPhoneTypeMenu;
        private System.Windows.Forms.ToolStripMenuItem AddOSMenu;
        private System.Windows.Forms.ToolStripMenuItem AddModelPhoneMenu;
        private System.Windows.Forms.ToolStripMenuItem тарифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTarifMenu;
        private System.Windows.Forms.ToolStripMenuItem AddServiceMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


using MobileOperator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileOperator
{
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Service.Add(NameBox.Text, DescriptionBox.Text, Convert.ToInt32(PriceBox.Text));
            MessageBox.Show("Услуга успешно добавлена.");
            Close();
        }
    }
}

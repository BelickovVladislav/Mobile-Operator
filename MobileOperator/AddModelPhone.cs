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
    public partial class AddModelPhone : Form
    {
        public AddModelPhone()
        {
            InitializeComponent();
            foreach(var producer in Producer.getList())
            {
                ProducerBox.Items.Add(producer.Name);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ProducerBox.Text != "" && NameBox.Text != "")
            {
                foreach (var producer in Producer.getList())
                {
                    if (producer.Name == ProducerBox.Text)
                    {
                        ModelPhone.Add(NameBox.Text, producer);
                        MessageBox.Show("Производитель успешно добавлен.");
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните данные.");
            }
        }

        private void AddProducerBtn_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm("Producer");
            form.ShowDialog();
        }
    }
}

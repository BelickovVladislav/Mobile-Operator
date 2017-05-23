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
    public partial class AddForm : Form
    {
        private object Property;

        public AddForm(string property)
        {
            InitializeComponent();
            Property = property;
            switch(Property)
            {
                case "Producer": Text = "Добавления производителя"; break;
                case "PhoneType": Text = "Добавления типа телефона"; break;
                case "OS": Text = "Добавления операционной системы"; break;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AddBox.Text != "")
            {
                switch (Property)
                {
                    case "Producer": Producer.Add(AddBox.Text); break;
                    case "PhoneType": PhoneType.Add(AddBox.Text); break;
                    case "OS": OS.Add(AddBox.Text); break;
                }
                MessageBox.Show("Категория успешно добавлена.");
                Close();
            }
            else
                MessageBox.Show("Заполните поле категории.");
        }
    }
}

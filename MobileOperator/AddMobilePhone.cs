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
    public partial class AddMobilePhone : Form
    {
        private string photoUrl;

        public AddMobilePhone()
        {
            this.photoUrl = "";

            InitializeComponent();
            foreach (var producer in Producer.getList())
                ProducerBox.Items.Add(producer.Name);
            foreach (var typePhone in PhoneType.getList())
                TypePhoneBox.Items.Add(typePhone.Name);
            foreach (var os in OS.getList())
                OSBox.Items.Add(os.Name);
            
        }

        private void PhotoUploadBtn_Click(object sender, EventArgs e)
        {
            
            UploadPhotoForm uploadPhoto = new UploadPhotoForm(this.photoUrl);
            uploadPhoto.ShowDialog();
            this.photoUrl = uploadPhoto.url;
            this.PhotoBox.Load(this.photoUrl);
        }

        private void AddMobilePhoneBtn_Click(object sender, EventArgs e)
        {
            Producer prod = null;
            PhoneType type = null;
            OS _os = null;
            ModelPhone model = null;

            foreach (var producer in Producer.getList())
                if (producer.Name == (string)ProducerBox.SelectedItem)
                    prod = producer;
            foreach (var typePhone in PhoneType.getList())
                if (typePhone.Name == (string)TypePhoneBox.SelectedItem)
                    type = typePhone;

            foreach (var os in OS.getList())
                if (os.Name == (string)OSBox.SelectedItem)
                    _os = os;
            foreach (var modelPhone in ModelPhone.GetList())
                if (modelPhone.Name == (string)ModelPhoneBox.SelectedItem)
                    model = modelPhone;
            if (model == null) {
                MessageBox.Show("Выбирете модель телефона");
                return;
            }
            if (prod == null)
            {
                MessageBox.Show("Выбирете производителя телефона");
                return;
            }
            if (type == null)
            {
                MessageBox.Show("Выбирете производителя телефона");
                return;
            }
            if (_os == null)
            {
                MessageBox.Show("Выбирете ОС телефона");
                return;
            }

            MobilePhone.Add(prod,type,_os ,model,photoUrl,Convert.ToDouble(PriceBox.Text));
            MessageBox.Show("Телефон успешно добавлен!");
            this.Close();
        }

        private void SelectedValueChange(object sender, EventArgs e)
        {
            ModelPhoneBox.Items.Clear();
            foreach (var producer in Producer.getList())
                if (producer.Name == (string)ProducerBox.SelectedItem)
                    foreach (var modelPhone in ModelPhone.GetListByProducerId(producer.id))
                        ModelPhoneBox.Items.Add(modelPhone.Name);
        }
    }
}

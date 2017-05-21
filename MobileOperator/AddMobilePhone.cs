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
        private MobilePhone Phone = new MobilePhone();

        public AddMobilePhone()
        {
            InitializeComponent();
            foreach (var producer in Producer.getList())
                ProducerBox.Items.Add(producer.Name);
            foreach (var typePhone in PhoneType.getList())
                TypePhoneBox.Items.Add(typePhone.Name);
            foreach (var os in OS.getList())
                OSBox.Items.Add(os.Name);
            foreach (var modelPhone in ModelPhone.GetList())
                ModelPhoneBox.Items.Add(modelPhone.Name);
        }

        private void PhotoUploadBtn_Click(object sender, EventArgs e)
        {
            UploadPhotoForm uploadPhoto = new UploadPhotoForm(Phone);
            uploadPhoto.ShowDialog();
            this.PhotoBox.Load(Phone.photoUrl);
        }

        private void AddMobilePhoneBtn_Click(object sender, EventArgs e)
        {
            Phone.producer.Name = ProducerBox.Text;
            Phone.phoneType.Name = TypePhoneBox.Text;
            Phone.os.Name = OSBox.Text;
            Phone.modelPhone.Name = ModelPhoneBox.Text;
            Phone.price = Convert.ToDouble(PriceBox.Text);
        }
    }
}

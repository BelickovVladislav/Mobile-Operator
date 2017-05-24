using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileOperator.Objects;

namespace MobileOperator
{
    public partial class AddOwnerForm : Form
    {
        private Owner owner;
        private List<string> useSerivce;
        private List<string> UnuseSerivce;
        private string url;

        public AddOwnerForm()
        {
            InitializeComponent();

            useSerivce = new List<string>();
            UnuseSerivce = new List<string>();
            url = "";
            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();
            SurnameBox.Text = "";
            FirstNameBox.Text = "";
            MiddleNameBox.Text = "";

            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
            ServiceLstUse.Items.AddRange(useSerivce.ToArray());

            //SexBox.SelectedIndex = ;
            PassportBox.Text ="";
            NumberPhoneBox.Text = "";
            try
            {
                PhotoBox.Load("DefaultImage");
            }
            catch (Exception e) { }
        }

        public AddOwnerForm(Owner owner)
        {
            InitializeComponent();

            this.owner = owner;
            useSerivce = new List<string>();
            UnuseSerivce = new List<string>();
            url = owner.photoUrl;
            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();
            if (owner == null) Close();
            SurnameBox.Text = owner.surname;
            FirstNameBox.Text = owner.firstName;
            MiddleNameBox.Text = owner.middleName;
            FillTariffBox();
            foreach (var service in owner.services)
                useSerivce.Add(service.Name);
            foreach (var service in Service.getList())
                if (!useSerivce.Contains(service.Name))
                    UnuseSerivce.Add(service.Name);

            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
            ServiceLstUse.Items.AddRange(useSerivce.ToArray());

            FillMobilePhoneBox();
            SexBox.SelectedIndex = owner.sex ? 0 : 1;
            PassportBox.Text = owner.passportNumber;
            NumberPhoneBox.Text = owner.mobileNumber;
            try
            {
                PhotoBox.Load(owner.photoUrl);
            }
            catch (Exception e) { }
            AddOwnerBtn.Text = "Сохранить";

        }

        private void FillTariffBox()
        {
            TariffBox.Items.Clear();
            foreach (var tariff in Tariff.getList())
            {
                TariffBox.Items.Add(tariff.Name);
                if (tariff.Name == owner.tariff.Name)
                    TariffBox.SelectedIndex = TariffBox.Items.Count - 1;
            }
        }

        private void FillMobilePhoneBox()
        {
            PhoneBox.Items.Clear();
            foreach (var mobile in MobilePhone.getList())
            {
                PhoneBox.Items.Add(mobile.producer.Name + " " + mobile.modelPhone.Name);
                if (mobile.producer.Name + " " + mobile.modelPhone.Name == owner.mobilePhone.producer.Name + " " + owner.mobilePhone.modelPhone.Name)
                    PhoneBox.SelectedIndex = PhoneBox.Items.Count - 1;
            }
        }

        private void PhotoUploadBtn_Click(object sender, EventArgs e)
        {
            
            UploadPhotoForm uploadPhoto = new UploadPhotoForm(url);

            uploadPhoto.ShowDialog();
            url = uploadPhoto.url;
            try
            {
                this.PhotoBox.Load(url);
            }
            catch (Exception ex) { }
        }

        private void ServiceLstUnuse_Click(object sender, EventArgs e)
        {
            if (ServiceLstUnuse.Text != "")
            {
                useSerivce.Add(ServiceLstUnuse.Text);
                UnuseSerivce.Remove(ServiceLstUnuse.Text);
            }

            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();

            ServiceLstUse.Items.AddRange(useSerivce.ToArray());
            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
        }

        private void ServiceLstUse_Click(object sender, EventArgs e)
        {
            if (ServiceLstUse.Text != "")
            {
                UnuseSerivce.Add(ServiceLstUse.Text);
                useSerivce.Remove(ServiceLstUse.Text);
            }

            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();

            ServiceLstUse.Items.AddRange(useSerivce.ToArray());
            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
        }

        private void AddOwnerBtn_Click(object sender, EventArgs e)
        {
            if (this.owner == null)
                return; //TODO Owner.Add();
            owner.firstName = FirstNameBox.Text;
            owner.middleName = MiddleNameBox.Text;
            owner.surname = SurnameBox.Text;
            foreach (var mobile in MobilePhone.getList())
            {
                if (PhoneBox.SelectedItem.ToString() == mobile.producer.Name + " " + mobile.modelPhone.Name)
                {

                    owner.mobilePhone = mobile;
                    MessageBox.Show(owner.mobilePhone.id.ToString());
                    break;
                }
            }
            foreach (var tariff in Tariff.getList())
            {
                if (TariffBox.Text == tariff.Name)
                    owner.tariff = tariff;
            }
            List<Service> services = new List<Service>();
            foreach (var service in Service.getList())
                if (useSerivce.Contains(service.Name))
                    services.Add(service);
            owner.services = services;
            owner.sex = SexBox.SelectedIndex == 0;
            owner.passportNumber = PassportBox.Text;
            owner.mobileNumber = NumberPhoneBox.Text;
            owner.photoUrl = url;
            this.Close();
        }

        private void AddPhoneBtn_Click(object sender, EventArgs e)
        {
            AddMobilePhone addMobile = new AddMobilePhone();
            addMobile.ShowDialog();
            FillMobilePhoneBox();
        }
        

        private void AddTariffBtn_Click(object sender, EventArgs e)
        {
            AddTariffForm tariffForm = new AddTariffForm();
            tariffForm.ShowDialog();
            FillTariffBox();
        }
    }
}

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
        private double price;

        public AddOwnerForm()
        {
            InitializeComponent();
            price = 0;
            useSerivce = new List<string>();
            UnuseSerivce = new List<string>();

            foreach (var service in Service.getList())
                if (!useSerivce.Contains(service.Name))
                    UnuseSerivce.Add(service.Name);

            url = "";
            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();
            SurnameBox.Text = "";
            FirstNameBox.Text = "";
            MiddleNameBox.Text = "";

            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
            ServiceLstUse.Items.AddRange(useSerivce.ToArray());

            FillTariffBox();
            FillMobilePhoneBox();

            PassportBox.Text = "";
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
            FillMobilePhoneBox();

            foreach (var service in owner.services)
                useSerivce.Add(service.Name);
            foreach (var service in Service.getList())
                if (!useSerivce.Contains(service.Name))
                    UnuseSerivce.Add(service.Name);

            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
            ServiceLstUse.Items.AddRange(useSerivce.ToArray());

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
                try
                {
                    if (tariff.Name == owner.tariff.Name)
                        TariffBox.SelectedIndex = TariffBox.Items.Count - 1;
                }
                catch { }
            }
        }

        private void FillMobilePhoneBox()
        {
            PhoneBox.Items.Clear();
            foreach (var mobile in MobilePhone.getList())
            {
                PhoneBox.Items.Add(mobile.producer.Name + " " + mobile.modelPhone.Name);
                try
                {
                    if (mobile.producer.Name + " " + mobile.modelPhone.Name == owner.mobilePhone.producer.Name + " " + owner.mobilePhone.modelPhone.Name)
                        PhoneBox.SelectedIndex = PhoneBox.Items.Count - 1;
                }
                catch { }
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
            if (owner == null)
            {
                Tariff Tariff = null;
                MobilePhone Mobile = null;
                bool sex = SexBox.Text == "Мужской" ? true : false;
                foreach (var tariff in Tariff.getList())
                    if (tariff.Name == TariffBox.Text)
                        Tariff = tariff;
                foreach (var mobile in MobilePhone.getList())
                    if (mobile.producer.Name + " " + mobile.modelPhone.Name == PhoneBox.Text)
                        Mobile = mobile;
                Objects.Owner.Add(Mobile, Tariff, SurnameBox.Text, MiddleNameBox.Text, FirstNameBox.Text, sex, url, PassportBox.Text, NumberPhoneBox.Text);
                Close();
            }
            else
            {
                owner.firstName = FirstNameBox.Text;
                owner.middleName = MiddleNameBox.Text;
                owner.surname = SurnameBox.Text;
                foreach (var mobile in MobilePhone.getList())
                {
                    if (PhoneBox.SelectedItem.ToString() == mobile.producer.Name + " " + mobile.modelPhone.Name)
                    {

                        owner.mobilePhone = mobile;
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
                Close();
            }

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

        private void TariffBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultPriceBox.Text = "Ежемесячная плата " + resultPrice() + " руб.";
        }

        public double resultPrice()
        {
            price = 0;
            foreach (var tariff in Tariff.getList())
                if (tariff.Name == TariffBox.Text)
                    price += tariff.Price;
            for (int i = 0; i < ServiceLstUse.Items.Count; i++)
            {
                foreach (var serviceName in Service.getList())
                {
                    if (serviceName.Name == ServiceLstUse.Items[i].ToString())
                    {
                        price += serviceName.Price;
                    }
                }
            }
            return price;
        }
    }
}
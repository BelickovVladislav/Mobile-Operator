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
    public partial class AddTariffForm : Form
    {
        private List<string> useSerivce;
        private List<string> UnuseSerivce;

        public AddTariffForm()
        {
            InitializeComponent();
            useSerivce = new List<string>();
            UnuseSerivce = new List<string>();
            ServiceLstUse.Items.Clear();
            ServiceLstUnuse.Items.Clear();
            foreach (var service in Service.getList())
                UnuseSerivce.Add(service.Name);
            ServiceLstUnuse.Items.AddRange(UnuseSerivce.ToArray());
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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            List<Service> services = new List<Service>();
            foreach (var service in Service.getList())
                if (useSerivce.Contains(service.Name))
                    services.Add(service);
            Tariff.Add(NameBox.Text, DescriptionBox.Text, double.Parse(PriceBox.Text));
            List<Tariff> tarrifs = Tariff.getList();
            tarrifs[tarrifs.Count-1].Services = services;
            this.Close();
        }
    }
}

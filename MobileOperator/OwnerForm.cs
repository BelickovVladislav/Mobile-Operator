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
    public partial class OwnerForm : Form
    {
        private List<Objects.Owner> list = Objects.Owner.getList();
        public OwnerForm()
        {
            InitializeComponent();
            openOwner();
        }

        public void openOwner()
        {
            OwnerView.Rows.Clear();
            foreach (var user in list)
            {
                OwnerView.Rows.Add(user.id, user.firstName + " " + user.middleName + " " + user.surname, user.mobileNumber, user.passportNumber, "x");
            }
        }
        
        private void OwnerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void OwnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySQL.getInstance().close();
        }

        private void OwnerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) == null)
            {
                foreach (var user in list)
                    if (user.id == int.Parse((((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        AddOwnerForm ownerForm = new AddOwnerForm(user);
                        ownerForm.ShowDialog();
                        openOwner();
                        return;
                    }
            }
            else
            {
                if (MessageBox.Show("Вы действительно желаете удалить данную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Objects.Owner.Delete(Convert.ToInt32(OwnerView.Rows[e.RowIndex].Cells[0].Value));
                    OwnerView.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Пользователь успешно удалён.");
                }
            }
        }

        private void AddOwnerMenu_Click(object sender, EventArgs e)
        {
            AddOwnerForm form = new AddOwnerForm();
            form.ShowDialog();
            openOwner();
        }

        private void AddMobilePhoneMenu_Click(object sender, EventArgs e)
        {
            AddMobilePhone form = new AddMobilePhone();
            form.ShowDialog();
        }

        private void AddProducerMenu_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm("Producer");
            form.ShowDialog();
        }

        private void AddPhoneTypeMenu_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm("PhoneType");
            form.ShowDialog();
        }

        private void AddOSMenu_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm("OS");
            form.ShowDialog();
        }

        private void AddModelPhoneMenu_Click(object sender, EventArgs e)
        {
            AddMobilePhone form = new AddMobilePhone();
            form.ShowDialog();
        }

        private void AddTarifMenu_Click(object sender, EventArgs e)
        {
            AddTariffForm form = new AddTariffForm();
            form.ShowDialog();
        }

        private void AddServiceMenu_Click(object sender, EventArgs e)
        {
            AddServiceForm form = new AddServiceForm();
            form.ShowDialog();
        }
    }
}
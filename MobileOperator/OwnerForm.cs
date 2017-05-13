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
        public OwnerForm()
        {
            InitializeComponent();
            var list = Objects.Owner.getList();
            foreach (var user in list)
            {
                OwnerView.Rows.Add(user.firstName+" "+user.middleName+" "+user.surname, user.mobileNumber);
            }

        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void OwnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySQL.getInstance().close();
        }
    }
}

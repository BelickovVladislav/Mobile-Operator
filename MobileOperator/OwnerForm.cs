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
            
            foreach (var user in list)
            { 
                OwnerView.Rows.Add(user.id, user.firstName+" "+user.middleName+" "+user.surname, user.mobileNumber, user.passportNumber, "x");
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
                        return;
                    }
            }
            else
            {
                MessageBox.Show(this,"Вы действительно желаете удалить данную запись?");//TODO Owner.delete(id);
            }


        }
    }
}

using MobileOperator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileOperator
{
    public partial class UploadPhotoForm : Form
    {
        public string url { get; set; }

        public UploadPhotoForm(string  url)
        {
            InitializeComponent();
            this.url = url;
            textBoxURL.Text = url;
        }

      

        private void Upload_Click(object sender, EventArgs e)
        {
            url = textBoxURL.Text.Replace('\\', '/');
            this.Close();
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "pic files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            textBoxURL.Text = openFileDialog1.FileName;
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            this.Close();
        }
    }
}

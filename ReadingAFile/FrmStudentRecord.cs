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

namespace ReadingAFile
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            {
                dlg.InitialDirectory = @"C:\";
                dlg.Title = "Find Student Record";
                dlg.DefaultExt = "txt";
                dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName;
                lvStudentText.Items.Clear();

                using (StreamReader reader = File.OpenText(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lvStudentText.Items.Add(line);
                    }
                }



            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Successfully Uploaded!");
            lvStudentText.Items.Clear();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmRegistration frm = new FrmRegistration();
            frm.Show();

        }
    }
}

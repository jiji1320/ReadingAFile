using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingAFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {

            FrmStudentRecord frm = new FrmStudentRecord();
            frm.Show();
            this.Hide();

        }
    }
}

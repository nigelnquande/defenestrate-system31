using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syskey
{
    public partial class Syskey : Form
    {
        public Syskey()
        {
            InitializeComponent();
        }

        private void Syskey_Load(object sender, EventArgs e)
        {
            this.pictureBox.Image = this.imageList.Images[0];
        }

        private void ShowUpdateDialog() {
            UpdateForm update = new UpdateForm();
            DialogResult res = update.ShowDialog(this);
            if (res == DialogResult.Cancel || res == DialogResult.Abort) this.Close();
        }

        private void descripLbl_Click(object sender, EventArgs e) {

        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            ShowUpdateDialog();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace syskey
{
    public partial class UpdateForm : Form {
        public UpdateForm () {
            InitializeComponent();
        }

        private void UpdateForm_Load (object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles when user clicks on the close "X" in the toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateForm_FormClosing (object sender, FormClosingEventArgs e) {
            switch (e.CloseReason) {
                case CloseReason.ApplicationExitCall:
                case CloseReason.FormOwnerClosing:
                case CloseReason.TaskManagerClosing:
                case CloseReason.UserClosing:
                case CloseReason.WindowsShutDown:
                    return;
                default: break;
            }
            if (this.DialogResult == DialogResult.Cancel || this.DialogResult == DialogResult.Abort) return;
            else e.Cancel = true;
        }

        private void showPasswordWarning () {
            if (pwdConfirmTxt.Text.Length == 0 || pwdConfirmTxt.Text.Length == 0 || !pwdConfirmTxt.Text.Equals(pwdTxt.Text)) {
                pwdConfirmTxt.BackColor = Color.Red;
                pwdConfirmTxt.ForeColor = Color.DarkRed;
                pwdConfirmTxt.SelectAll();
                // disable "OK" button
                this.OKBtn.Enabled = false;
                DialogResult dr = MessageBox.Show(
                       "There is no password entered in the password fields or the passwords do not match. Please enter a password.",
                       "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            } else {
                pwdConfirmTxt.ForeColor = Color.DarkGreen;
                pwdConfirmTxt.BackColor = Color.LightGreen;
                // enable "OK" button
                this.OKBtn.Enabled = true;
                this.OKBtn.Focus();
            }
        }

        private void pwdConfirmTxt_Leave (object sender, EventArgs e)
        {
            if (passwordStartupRadioGrpBox.Checked) {
                showPasswordWarning();
            }
        }

        private void cancelBtn_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDatabaseUpdated () {
            DialogResult dr = MessageBox.Show(
                    "The Account Database Startup Key was changed.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
        }

        private void OKBtn_Click (object sender, EventArgs e)
        {
            if (this.passwordStartupRadioGrpBox.Checked) {
                if (this.pwdTxt.Text.Length == 0 || this.pwdConfirmTxt.Text.Length == 0 || !this.pwdConfirmTxt.Text.Equals(this.pwdTxt.Text)) {
                    showPasswordWarning();
                } else { showDatabaseUpdated(); this.Close(); }
            } else if (this.storeLocallyRadioBtn.Checked) {
                showDatabaseUpdated();
                this.Close();
            } else /* if (this.storeFloppyRadioBtn.Checked) */ {
                DialogResult dr = MessageBox.Show(
                    "Insert a disk into Drive A: that will be used to save the Startup key.", "Save Startup Key",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                );
                if (dr == DialogResult.OK) {
                    int randomAddress = new Random().Next();
                    
                    dr = MessageBox.Show(
                        "Error 321 occurred in memory address 0x" + randomAddress.ToString("X8") + 
                        ".\nThe disk device mounted at path (A:\\) is unreachable.",
                        "Error 321", MessageBoxButtons.OKCancel, MessageBoxIcon.Error
                    );
                }
                this.Close();
            }
        }

        private void storeLocallyRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            //floppyStartupRadioBtn.Checked = !storeLocallyRadioBtn.Checked;
        }

        private void floppyStartupRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            //storeLocallyRadioBtn.Checked = !floppyStartupRadioBtn.Checked;
        }

        private void sysGenPwdRadioGrpBox_CheckedChanged (object sender, EventArgs e)
        {
            this.OKBtn.Enabled = true;
        }
    }
}

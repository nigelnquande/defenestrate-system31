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
    public partial class UpdateForm : Form
    {
        public UpdateForm ()
        {
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

        private void passwordStartupRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            this.reqStartPwdLbl.Enabled = passwordStartupRadioBtn.Checked;
            this.startPwdConfLbl.Enabled = passwordStartupRadioBtn.Checked;
            this.startPwdLbl.Enabled = passwordStartupRadioBtn.Checked;
            this.startPwdTxt.Enabled = passwordStartupRadioBtn.Checked;
            this.confirmStartPwdTxt.Enabled = passwordStartupRadioBtn.Checked;
            this.sysGenPwdRadioBtn.Checked = !passwordStartupRadioBtn.Checked;
        }

        private void confirmPwtText_Leave (object sender, EventArgs e)
        {
            if (passwordStartupRadioBtn.Checked) {
                if (!confirmStartPwdTxt.Text.Equals(startPwdTxt.Text)) {
                    confirmStartPwdTxt.BackColor = Color.Red;
                    confirmStartPwdTxt.ForeColor = Color.DarkRed; 
                    // disable "OK" button
                } else {
                    confirmStartPwdTxt.ForeColor = Color.DarkGreen;
                    confirmStartPwdTxt.BackColor = Color.LightGreen;
                    // enable "OK" button
                }
            }
        }

        private void sysGenPwdRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            passwordStartupRadioBtn.Checked = !this.sysGenPwdRadioBtn.Checked;
            // set the enabled state of components within the applicable group box
            /*
            this.floppyStartupRadioBtn.Enabled = sysGenPwdRadioBtn.Checked;
            this.reqFloppyLbl.Enabled = sysGenPwdRadioBtn.Checked;
            this.storeLocallyRadioBtn.Enabled = sysGenPwdRadioBtn.Checked;
            this.storeLocalKeyLbl.Enabled = sysGenPwdRadioBtn.Checked;
            */
            this.sysPanel.Enabled = sysGenPwdRadioBtn.Checked;
        }

        private void cancelBtn_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click (object sender, EventArgs e)
        {
            if (this.passwordStartupRadioBtn.Checked || this.storeLocallyRadioBtn.Checked) {
                DialogResult dr = MessageBox.Show(
                    "The Account Database Startup Key was changed.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
       
            } else if (floppyStartupRadioBtn.Checked) {
                DialogResult dr = MessageBox.Show(
                    "Error 321 occurred in memory address 0x545DA5435E.\nThe device mounted at path (A:\\) is unreachable.", 
                    "Error 321", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error
                );

            }
            this.Close();
        }

        private void storeLocallyRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            floppyStartupRadioBtn.Checked = !storeLocallyRadioBtn.Checked;
        }

        private void floppyStartupRadioBtn_CheckedChanged (object sender, EventArgs e)
        {
            storeLocallyRadioBtn.Checked = !floppyStartupRadioBtn.Checked;
        }
    }
}

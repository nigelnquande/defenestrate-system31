using System.Windows.Forms;
using System.ComponentModel;
/* Using UIToolbox.RadioGroupBox library developed by Jeff Beeghly <mailto:jeffb42@hotmail.com>
 * Originally published at http://www.codeproject.com/KB/miscctrl/CheckGBAndRadioGB.aspx
 */
using UIToolbox;

namespace syskey
{
    partial class UpdateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.mainPanel = new UIToolbox.RadioButtonPanel();
            this.passwordStartupRadioGrpBox = new UIToolbox.RadioGroupBox();
            this.pwdConfirmTxt = new System.Windows.Forms.TextBox();
            this.pwdConfirmLbl = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.reqPwdLbl = new System.Windows.Forms.Label();
            this.sysGenPwdRadioGrpBox = new UIToolbox.RadioGroupBox();
            this.sysGenPwdPanel = new UIToolbox.RadioButtonPanel();
            this.storeLocallyLbl = new System.Windows.Forms.Label();
            this.storeLocallyRadioBtn = new System.Windows.Forms.RadioButton();
            this.reqFloppyLbl = new System.Windows.Forms.Label();
            this.storeFloppyRadioBtn = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.passwordStartupRadioGrpBox.SuspendLayout();
            this.sysGenPwdRadioGrpBox.SuspendLayout();
            this.sysGenPwdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.passwordStartupRadioGrpBox);
            this.mainPanel.Controls.Add(this.sysGenPwdRadioGrpBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(279, 330);
            this.mainPanel.TabIndex = 0;
            // 
            // passwordStartupRadioGrpBox
            // 
            this.passwordStartupRadioGrpBox.Controls.Add(this.pwdConfirmTxt);
            this.passwordStartupRadioGrpBox.Controls.Add(this.pwdConfirmLbl);
            this.passwordStartupRadioGrpBox.Controls.Add(this.pwdTxt);
            this.passwordStartupRadioGrpBox.Controls.Add(this.pwdLbl);
            this.passwordStartupRadioGrpBox.Controls.Add(this.reqPwdLbl);
            this.passwordStartupRadioGrpBox.DisableChildrenIfUnchecked = true;
            this.passwordStartupRadioGrpBox.Location = new System.Drawing.Point(10, 10);
            this.passwordStartupRadioGrpBox.Name = "passwordStartupRadioGrpBox";
            this.passwordStartupRadioGrpBox.Size = new System.Drawing.Size(260, 120);
            this.passwordStartupRadioGrpBox.TabIndex = 1;
            this.passwordStartupRadioGrpBox.TabStop = false;
            this.passwordStartupRadioGrpBox.Text = "Password Startup";
            // 
            // pwdConfirmTxt
            // 
            this.pwdConfirmTxt.Location = new System.Drawing.Point(100, 87);
            this.pwdConfirmTxt.MaxLength = 128;
            this.pwdConfirmTxt.Name = "pwdConfirmTxt";
            this.pwdConfirmTxt.PasswordChar = '*';
            this.pwdConfirmTxt.Size = new System.Drawing.Size(150, 20);
            this.pwdConfirmTxt.TabIndex = 6;
            this.pwdConfirmTxt.UseSystemPasswordChar = true;
            this.pwdConfirmTxt.WordWrap = false;
            this.pwdConfirmTxt.Leave += new System.EventHandler(this.pwdConfirmTxt_Leave);
            // 
            // pwdConfirmLbl
            // 
            this.pwdConfirmLbl.Location = new System.Drawing.Point(15, 90);
            this.pwdConfirmLbl.Name = "pwdConfirmLbl";
            this.pwdConfirmLbl.Size = new System.Drawing.Size(80, 20);
            this.pwdConfirmLbl.TabIndex = 5;
            this.pwdConfirmLbl.Text = "Confirm:";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(100, 57);
            this.pwdTxt.MaxLength = 128;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(150, 20);
            this.pwdTxt.TabIndex = 4;
            this.pwdTxt.UseSystemPasswordChar = true;
            this.pwdTxt.WordWrap = false;
            // 
            // pwdLbl
            // 
            this.pwdLbl.Location = new System.Drawing.Point(15, 60);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(80, 20);
            this.pwdLbl.TabIndex = 3;
            this.pwdLbl.Text = "Password:";
            // 
            // reqPwdLbl
            // 
            this.reqPwdLbl.Location = new System.Drawing.Point(15, 20);
            this.reqPwdLbl.Name = "reqPwdLbl";
            this.reqPwdLbl.Size = new System.Drawing.Size(240, 30);
            this.reqPwdLbl.TabIndex = 2;
            this.reqPwdLbl.Text = "Requires a password to be entered during system start.";
            // 
            // sysGenPwdRadioGrpBox
            // 
            this.sysGenPwdRadioGrpBox.Checked = true;
            this.sysGenPwdRadioGrpBox.Controls.Add(this.sysGenPwdPanel);
            this.sysGenPwdRadioGrpBox.DisableChildrenIfUnchecked = true;
            this.sysGenPwdRadioGrpBox.Location = new System.Drawing.Point(10, 150);
            this.sysGenPwdRadioGrpBox.Name = "sysGenPwdRadioGrpBox";
            this.sysGenPwdRadioGrpBox.Size = new System.Drawing.Size(260, 175);
            this.sysGenPwdRadioGrpBox.TabIndex = 7;
            this.sysGenPwdRadioGrpBox.TabStop = false;
            this.sysGenPwdRadioGrpBox.Text = "System Generated Password";
            this.sysGenPwdRadioGrpBox.CheckedChanged += new System.EventHandler(this.sysGenPwdRadioGrpBox_CheckedChanged);
            // 
            // sysGenPwdPanel
            // 
            this.sysGenPwdPanel.Controls.Add(this.storeLocallyLbl);
            this.sysGenPwdPanel.Controls.Add(this.storeLocallyRadioBtn);
            this.sysGenPwdPanel.Controls.Add(this.reqFloppyLbl);
            this.sysGenPwdPanel.Controls.Add(this.storeFloppyRadioBtn);
            this.sysGenPwdPanel.Location = new System.Drawing.Point(5, 15);
            this.sysGenPwdPanel.Name = "sysGenPwdPanel";
            this.sysGenPwdPanel.Size = new System.Drawing.Size(250, 155);
            this.sysGenPwdPanel.TabIndex = 7;
            // 
            // storeLocallyLbl
            // 
            this.storeLocallyLbl.Location = new System.Drawing.Point(25, 100);
            this.storeLocallyLbl.Name = "storeLocallyLbl";
            this.storeLocallyLbl.Size = new System.Drawing.Size(225, 45);
            this.storeLocallyLbl.TabIndex = 11;
            this.storeLocallyLbl.Text = "Stores a key as a part of the operating system, and no interaction is required du" +
    "ring system start.";
            // 
            // storeLocallyRadioBtn
            // 
            this.storeLocallyRadioBtn.Checked = true;
            this.storeLocallyRadioBtn.Location = new System.Drawing.Point(15, 75);
            this.storeLocallyRadioBtn.Name = "storeLocallyRadioBtn";
            this.storeLocallyRadioBtn.Size = new System.Drawing.Size(200, 20);
            this.storeLocallyRadioBtn.TabIndex = 10;
            this.storeLocallyRadioBtn.TabStop = true;
            this.storeLocallyRadioBtn.Text = "Store Startup Key Locally";
            this.storeLocallyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // reqFloppyLbl
            // 
            this.reqFloppyLbl.Location = new System.Drawing.Point(25, 30);
            this.reqFloppyLbl.Name = "reqFloppyLbl";
            this.reqFloppyLbl.Size = new System.Drawing.Size(225, 30);
            this.reqFloppyLbl.TabIndex = 9;
            this.reqFloppyLbl.Text = "Requires a floppy disk to be inserted during system start.";
            // 
            // storeFloppyRadioBtn
            // 
            this.storeFloppyRadioBtn.Location = new System.Drawing.Point(15, 5);
            this.storeFloppyRadioBtn.Name = "storeFloppyRadioBtn";
            this.storeFloppyRadioBtn.Size = new System.Drawing.Size(200, 20);
            this.storeFloppyRadioBtn.TabIndex = 8;
            this.storeFloppyRadioBtn.Text = "Store Startup Key on Floppy Disk";
            this.storeFloppyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(75, 335);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 12;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(160, 335);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(279, 366);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(295, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 405);
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Startup Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.passwordStartupRadioGrpBox.ResumeLayout(false);
            this.passwordStartupRadioGrpBox.PerformLayout();
            this.sysGenPwdRadioGrpBox.ResumeLayout(false);
            this.sysGenPwdRadioGrpBox.PerformLayout();
            this.sysGenPwdPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private RadioButtonPanel mainPanel;
        private RadioButtonPanel sysGenPwdPanel;
        private RadioGroupBox passwordStartupRadioGrpBox;
        private RadioGroupBox sysGenPwdRadioGrpBox;

        #endregion
        private Button OKBtn;
        private Button cancelBtn;
        private Label reqPwdLbl;
        private TextBox pwdConfirmTxt;
        private Label pwdConfirmLbl;
        private TextBox pwdTxt;
        private Label pwdLbl;
        private RadioButton storeFloppyRadioBtn;
        private Label reqFloppyLbl;
        private Label storeLocallyLbl;
        private RadioButton storeLocallyRadioBtn;
    }
}
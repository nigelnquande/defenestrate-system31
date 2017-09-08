namespace syskey
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.passwordStartupGrpBox = new System.Windows.Forms.GroupBox();
            this.passwordStartupRadioBtn = new System.Windows.Forms.RadioButton();
            this.reqStartPwdLbl = new System.Windows.Forms.Label();
            this.startPwdLbl = new System.Windows.Forms.Label();
            this.startPwdTxt = new System.Windows.Forms.TextBox();
            this.startPwdConfLbl = new System.Windows.Forms.Label();
            this.confirmStartPwdTxt = new System.Windows.Forms.TextBox();
            this.sysGenGrpBox = new System.Windows.Forms.GroupBox();
            this.sysGenPwdRadioBtn = new System.Windows.Forms.RadioButton();
            this.floppyStartupRadioBtn = new System.Windows.Forms.RadioButton();
            this.reqFloppyLbl = new System.Windows.Forms.Label();
            this.storeLocallyRadioBtn = new System.Windows.Forms.RadioButton();
            this.storeLocalKeyLbl = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passwordStartupGrpBox.SuspendLayout();
            this.sysGenGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordStartupGrpBox
            // 
            this.passwordStartupGrpBox.Controls.Add(this.confirmStartPwdTxt);
            this.passwordStartupGrpBox.Controls.Add(this.startPwdConfLbl);
            this.passwordStartupGrpBox.Controls.Add(this.startPwdTxt);
            this.passwordStartupGrpBox.Controls.Add(this.startPwdLbl);
            this.passwordStartupGrpBox.Controls.Add(this.reqStartPwdLbl);
            this.passwordStartupGrpBox.Controls.Add(this.passwordStartupRadioBtn);
            this.passwordStartupGrpBox.Location = new System.Drawing.Point(10, 10);
            this.passwordStartupGrpBox.Name = "passwordStartupGrpBox";
            this.passwordStartupGrpBox.Size = new System.Drawing.Size(260, 130);
            this.passwordStartupGrpBox.TabIndex = 0;
            this.passwordStartupGrpBox.TabStop = false;
            // 
            // passwordStartupRadioBtn
            // 
            this.passwordStartupRadioBtn.AutoCheck = false;
            this.passwordStartupRadioBtn.AutoSize = true;
            this.passwordStartupRadioBtn.Location = new System.Drawing.Point(6, -2);
            this.passwordStartupRadioBtn.Name = "passwordStartupRadioBtn";
            this.passwordStartupRadioBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.passwordStartupRadioBtn.Size = new System.Drawing.Size(113, 17);
            this.passwordStartupRadioBtn.TabIndex = 0;
            this.passwordStartupRadioBtn.Text = "Password Startup";
            this.passwordStartupRadioBtn.UseVisualStyleBackColor = true;
            this.passwordStartupRadioBtn.CheckedChanged += new System.EventHandler(this.passwordStartupRadioBtn_CheckedChanged);
            // 
            // reqStartPwdLbl
            // 
            this.reqStartPwdLbl.Enabled = false;
            this.reqStartPwdLbl.Location = new System.Drawing.Point(10, 25);
            this.reqStartPwdLbl.Name = "reqStartPwdLbl";
            this.reqStartPwdLbl.Size = new System.Drawing.Size(242, 29);
            this.reqStartPwdLbl.TabIndex = 1;
            this.reqStartPwdLbl.Text = "Requires a password to be entered during system start.";
            // 
            // startPwdLbl
            // 
            this.startPwdLbl.Enabled = false;
            this.startPwdLbl.Location = new System.Drawing.Point(10, 65);
            this.startPwdLbl.Name = "startPwdLbl";
            this.startPwdLbl.Size = new System.Drawing.Size(75, 20);
            this.startPwdLbl.TabIndex = 2;
            this.startPwdLbl.Text = "Password:";
            // 
            // startPwdTxt
            // 
            this.startPwdTxt.Enabled = false;
            this.startPwdTxt.Location = new System.Drawing.Point(90, 62);
            this.startPwdTxt.MaxLength = 128;
            this.startPwdTxt.Name = "startPwdTxt";
            this.startPwdTxt.PasswordChar = '*';
            this.startPwdTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startPwdTxt.Size = new System.Drawing.Size(160, 20);
            this.startPwdTxt.TabIndex = 3;
            this.startPwdTxt.UseSystemPasswordChar = true;
            // 
            // startPwdConfLbl
            // 
            this.startPwdConfLbl.Enabled = false;
            this.startPwdConfLbl.Location = new System.Drawing.Point(10, 95);
            this.startPwdConfLbl.Name = "startPwdConfLbl";
            this.startPwdConfLbl.Size = new System.Drawing.Size(75, 20);
            this.startPwdConfLbl.TabIndex = 4;
            this.startPwdConfLbl.Text = "Confirm:";
            // 
            // confirmStartPwdTxt
            // 
            this.confirmStartPwdTxt.Enabled = false;
            this.confirmStartPwdTxt.Location = new System.Drawing.Point(90, 92);
            this.confirmStartPwdTxt.MaxLength = 128;
            this.confirmStartPwdTxt.Name = "confirmStartPwdTxt";
            this.confirmStartPwdTxt.PasswordChar = '*';
            this.confirmStartPwdTxt.Size = new System.Drawing.Size(160, 20);
            this.confirmStartPwdTxt.TabIndex = 5;
            this.confirmStartPwdTxt.UseSystemPasswordChar = true;
            this.confirmStartPwdTxt.Leave += new System.EventHandler(this.confirmPwtText_Leave);
            // 
            // sysGenGrpBox
            // 
            this.sysGenGrpBox.Controls.Add(this.storeLocalKeyLbl);
            this.sysGenGrpBox.Controls.Add(this.storeLocallyRadioBtn);
            this.sysGenGrpBox.Controls.Add(this.reqFloppyLbl);
            this.sysGenGrpBox.Controls.Add(this.floppyStartupRadioBtn);
            this.sysGenGrpBox.Controls.Add(this.sysGenPwdRadioBtn);
            this.sysGenGrpBox.Location = new System.Drawing.Point(10, 160);
            this.sysGenGrpBox.Name = "sysGenGrpBox";
            this.sysGenGrpBox.Size = new System.Drawing.Size(260, 160);
            this.sysGenGrpBox.TabIndex = 6;
            this.sysGenGrpBox.TabStop = false;
            // 
            // sysGenPwdRadioBtn
            // 
            this.sysGenPwdRadioBtn.AutoCheck = false;
            this.sysGenPwdRadioBtn.AutoSize = true;
            this.sysGenPwdRadioBtn.Checked = true;
            this.sysGenPwdRadioBtn.Location = new System.Drawing.Point(6, -2);
            this.sysGenPwdRadioBtn.Name = "sysGenPwdRadioBtn";
            this.sysGenPwdRadioBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sysGenPwdRadioBtn.Size = new System.Drawing.Size(166, 17);
            this.sysGenPwdRadioBtn.TabIndex = 6;
            this.sysGenPwdRadioBtn.TabStop = true;
            this.sysGenPwdRadioBtn.Text = "System Generated Password";
            this.sysGenPwdRadioBtn.UseVisualStyleBackColor = true;
            this.sysGenPwdRadioBtn.CheckedChanged += new System.EventHandler(this.sysGenPwdRadioBtn_CheckedChanged);
            // 
            // floppyStartupRadioBtn
            // 
            this.floppyStartupRadioBtn.AutoCheck = false;
            this.floppyStartupRadioBtn.AutoSize = true;
            this.floppyStartupRadioBtn.Location = new System.Drawing.Point(25, 20);
            this.floppyStartupRadioBtn.Name = "floppyStartupRadioBtn";
            this.floppyStartupRadioBtn.Size = new System.Drawing.Size(181, 17);
            this.floppyStartupRadioBtn.TabIndex = 7;
            this.floppyStartupRadioBtn.TabStop = true;
            this.floppyStartupRadioBtn.Text = "Store Startup Key on Floppy Disk";
            this.floppyStartupRadioBtn.UseVisualStyleBackColor = true;
            this.floppyStartupRadioBtn.CheckedChanged += new System.EventHandler(this.floppyStartupRadioBtn_CheckedChanged);
            // 
            // reqFloppyLbl
            // 
            this.reqFloppyLbl.Location = new System.Drawing.Point(35, 40);
            this.reqFloppyLbl.Name = "reqFloppyLbl";
            this.reqFloppyLbl.Size = new System.Drawing.Size(220, 28);
            this.reqFloppyLbl.TabIndex = 8;
            this.reqFloppyLbl.Text = "Requires a floppy disk to be inserted during system start.";
            // 
            // storeLocallyRadioBtn
            // 
            this.storeLocallyRadioBtn.AutoCheck = false;
            this.storeLocallyRadioBtn.AutoSize = true;
            this.storeLocallyRadioBtn.Checked = true;
            this.storeLocallyRadioBtn.Location = new System.Drawing.Point(25, 80);
            this.storeLocallyRadioBtn.Name = "storeLocallyRadioBtn";
            this.storeLocallyRadioBtn.Size = new System.Drawing.Size(144, 17);
            this.storeLocallyRadioBtn.TabIndex = 9;
            this.storeLocallyRadioBtn.Text = "Store Startup Key Locally";
            this.storeLocallyRadioBtn.UseVisualStyleBackColor = true;
            this.storeLocallyRadioBtn.CheckedChanged += new System.EventHandler(this.storeLocallyRadioBtn_CheckedChanged);
            // 
            // storeLocalKeyLbl
            // 
            this.storeLocalKeyLbl.Location = new System.Drawing.Point(35, 105);
            this.storeLocalKeyLbl.Name = "storeLocalKeyLbl";
            this.storeLocalKeyLbl.Size = new System.Drawing.Size(220, 45);
            this.storeLocalKeyLbl.TabIndex = 10;
            this.storeLocalKeyLbl.Text = "Stores a key as part of the operating system, and no interaction is required duri" +
    "ng system start.";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(75, 335);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 11;
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
            this.cancelBtn.TabIndex = 12;
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
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.sysGenGrpBox);
            this.Controls.Add(this.passwordStartupGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 410);
            this.Name = "UpdateForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Startup Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.passwordStartupGrpBox.ResumeLayout(false);
            this.passwordStartupGrpBox.PerformLayout();
            this.sysGenGrpBox.ResumeLayout(false);
            this.sysGenGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox passwordStartupGrpBox;
        private System.Windows.Forms.RadioButton passwordStartupRadioBtn;
        private System.Windows.Forms.Label reqStartPwdLbl;
        private System.Windows.Forms.TextBox startPwdTxt;
        private System.Windows.Forms.Label startPwdLbl;
        private System.Windows.Forms.TextBox confirmStartPwdTxt;
        private System.Windows.Forms.Label startPwdConfLbl;
        private System.Windows.Forms.GroupBox sysGenGrpBox;
        private System.Windows.Forms.RadioButton sysGenPwdRadioBtn;
        private System.Windows.Forms.RadioButton floppyStartupRadioBtn;
        private System.Windows.Forms.Label reqFloppyLbl;
        private System.Windows.Forms.Label storeLocalKeyLbl;
        private System.Windows.Forms.RadioButton storeLocallyRadioBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
namespace syskey
{
    partial class Syskey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Syskey));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.descripLbl = new System.Windows.Forms.Label();
            this.enabledLbl = new System.Windows.Forms.Label();
            this.disabledRadioBtn = new System.Windows.Forms.RadioButton();
            this.enabledRadioBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Syskey.png");
            // 
            // pictureBox
            // 
            this.pictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox.Location = new System.Drawing.Point(15, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 37);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // descripLbl
            // 
            this.descripLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.descripLbl.Location = new System.Drawing.Point(80, 15);
            this.descripLbl.Name = "descripLbl";
            this.descripLbl.Size = new System.Drawing.Size(240, 45);
            this.descripLbl.TabIndex = 1;
            this.descripLbl.Text = "This tool will allow you to configure the Accounts Database to enable additional " +
    "encryption, further protecting the database from compromise.";
            this.descripLbl.Click += new System.EventHandler(this.descripLbl_Click);
            // 
            // enabledLbl
            // 
            this.enabledLbl.Location = new System.Drawing.Point(80, 70);
            this.enabledLbl.Name = "enabledLbl";
            this.enabledLbl.Size = new System.Drawing.Size(237, 27);
            this.enabledLbl.TabIndex = 2;
            this.enabledLbl.Text = "Once enabled, this encryption cannot be disabled.";
            // 
            // disabledRadioBtn
            // 
            this.disabledRadioBtn.AutoSize = true;
            this.disabledRadioBtn.Enabled = false;
            this.disabledRadioBtn.Location = new System.Drawing.Point(80, 115);
            this.disabledRadioBtn.Name = "disabledRadioBtn";
            this.disabledRadioBtn.Size = new System.Drawing.Size(119, 17);
            this.disabledRadioBtn.TabIndex = 3;
            this.disabledRadioBtn.Text = "Encryption Disabled";
            this.disabledRadioBtn.UseVisualStyleBackColor = true;
            // 
            // enabledRadioBtn
            // 
            this.enabledRadioBtn.AutoSize = true;
            this.enabledRadioBtn.Checked = true;
            this.enabledRadioBtn.Location = new System.Drawing.Point(80, 140);
            this.enabledRadioBtn.Name = "enabledRadioBtn";
            this.enabledRadioBtn.Size = new System.Drawing.Size(117, 17);
            this.enabledRadioBtn.TabIndex = 4;
            this.enabledRadioBtn.TabStop = true;
            this.enabledRadioBtn.Text = "Encryption Enabled";
            this.enabledRadioBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(55, 175);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(65, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(130, 175);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(215, 175);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Syskey
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(334, 206);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.enabledRadioBtn);
            this.Controls.Add(this.disabledRadioBtn);
            this.Controls.Add(this.enabledLbl);
            this.Controls.Add(this.descripLbl);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 245);
            this.Name = "Syskey";
            this.Text = "Securing the Windows Account Database";
            this.Load += new System.EventHandler(this.Syskey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label descripLbl;
        private System.Windows.Forms.Label enabledLbl;
        private System.Windows.Forms.RadioButton disabledRadioBtn;
        private System.Windows.Forms.RadioButton enabledRadioBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}


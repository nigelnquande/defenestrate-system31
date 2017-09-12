namespace run
{
    partial class RunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunForm));
            this.imageIcon = new System.Windows.Forms.PictureBox();
            this.runLbl = new System.Windows.Forms.Label();
            this.openLbl = new System.Windows.Forms.Label();
            this.openComboBox = new System.Windows.Forms.ComboBox();
            this.runPanel = new System.Windows.Forms.Panel();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).BeginInit();
            this.runPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageIcon
            // 
            this.imageIcon.Image = ((System.Drawing.Image)(resources.GetObject("imageIcon.Image")));
            this.imageIcon.Location = new System.Drawing.Point(10, 10);
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.Size = new System.Drawing.Size(32, 23);
            this.imageIcon.TabIndex = 0;
            this.imageIcon.TabStop = false;
            // 
            // runLbl
            // 
            this.runLbl.Location = new System.Drawing.Point(65, 10);
            this.runLbl.Name = "runLbl";
            this.runLbl.Size = new System.Drawing.Size(300, 30);
            this.runLbl.TabIndex = 1;
            this.runLbl.Text = "Type the name of a program, directory, document, or Internet resource, and Window" +
    "s will open it for you.";
            // 
            // openLbl
            // 
            this.openLbl.Location = new System.Drawing.Point(10, 60);
            this.openLbl.Name = "openLbl";
            this.openLbl.Size = new System.Drawing.Size(45, 20);
            this.openLbl.TabIndex = 2;
            this.openLbl.Text = "&Open:";
            // 
            // openComboBox
            // 
            this.openComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.openComboBox.FormattingEnabled = true;
            this.openComboBox.Location = new System.Drawing.Point(68, 57);
            this.openComboBox.Name = "openComboBox";
            this.openComboBox.Size = new System.Drawing.Size(285, 21);
            this.openComboBox.TabIndex = 3;
            // 
            // runPanel
            // 
            this.runPanel.BackColor = System.Drawing.Color.White;
            this.runPanel.Controls.Add(this.imageIcon);
            this.runPanel.Controls.Add(this.openComboBox);
            this.runPanel.Controls.Add(this.openLbl);
            this.runPanel.Controls.Add(this.runLbl);
            this.runPanel.Location = new System.Drawing.Point(0, 0);
            this.runPanel.Name = "runPanel";
            this.runPanel.Size = new System.Drawing.Size(375, 100);
            this.runPanel.TabIndex = 4;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(285, 115);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = "&Browse ...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(200, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(115, 115);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 7;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // RunForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(374, 151);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.runPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 190);
            this.Name = "RunForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Run";
            this.Load += new System.EventHandler(this.RunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).EndInit();
            this.runPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageIcon;
        private System.Windows.Forms.Label runLbl;
        private System.Windows.Forms.Label openLbl;
        private System.Windows.Forms.ComboBox openComboBox;
        private System.Windows.Forms.Panel runPanel;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OkBtn;
    }
}


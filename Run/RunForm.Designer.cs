namespace Run
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
            this.instructionLbl = new System.Windows.Forms.Label();
            this.imageIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            resources.ApplyResources(this.instructionLbl, "instructionLbl");
            this.instructionLbl.Name = "instructionLbl";
            // 
            // imageIcon
            // 
            this.imageIcon.Image = global::Run.Properties.Resources.Run_Command_icon;
            resources.ApplyResources(this.imageIcon, "imageIcon");
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.TabStop = false;
            // 
            // RunForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageIcon);
            this.Controls.Add(this.instructionLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunForm";
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.PictureBox imageIcon;
    }
}


namespace Lap4_RegisterationFoem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelRoot = new System.Windows.Forms.Panel();
            this.lblNamePlaceHolder = new System.Windows.Forms.Label();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.panelRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Name = "lblName";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Name = "txtName";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_Changed);
            // 
            // panelRoot
            // 
            this.panelRoot.Controls.Add(this.lblNamePlaceHolder);
            this.panelRoot.Controls.Add(this.cbxShowPassword);
            this.panelRoot.Controls.Add(this.txtPassword);
            this.panelRoot.Controls.Add(this.lblForgetPassword);
            this.panelRoot.Controls.Add(this.lblPassword);
            this.panelRoot.Controls.Add(this.txtName);
            this.panelRoot.Controls.Add(this.lblName);
            this.panelRoot.Controls.Add(this.lblOut);
            this.panelRoot.Controls.Add(this.lblSubmit);
            this.panelRoot.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelRoot, "panelRoot");
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNamePlaceHolder
            // 
            resources.ApplyResources(this.lblNamePlaceHolder, "lblNamePlaceHolder");
            this.lblNamePlaceHolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNamePlaceHolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNamePlaceHolder.Name = "lblNamePlaceHolder";
            this.lblNamePlaceHolder.Click += new System.EventHandler(this.lblNamePlaceHolder_Click);
            // 
            // cbxShowPassword
            // 
            resources.ApplyResources(this.cbxShowPassword, "cbxShowPassword");
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.UseVisualStyleBackColor = true;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_Checked);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_Changed);
            // 
            // lblForgetPassword
            // 
            resources.ApplyResources(this.lblForgetPassword, "lblForgetPassword");
            this.lblForgetPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
            this.lblForgetPassword.MouseLeave += new System.EventHandler(this.lblForgetPassword_Leave);
            this.lblForgetPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblForgetPassword_Move);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOut
            // 
            resources.ApplyResources(this.lblOut, "lblOut");
            this.lblOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOut.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOut.Name = "lblOut";
            this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
            this.lblOut.MouseLeave += new System.EventHandler(this.lblOut_Hover_Leave);
            this.lblOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOut_Hover_on);
            // 
            // lblSubmit
            // 
            resources.ApplyResources(this.lblSubmit, "lblSubmit");
            this.lblSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.lblSubmit.DoubleClick += new System.EventHandler(this.submit_Click);
            this.lblSubmit.MouseLeave += new System.EventHandler(this.submit_Hover_leave);
            this.lblSubmit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.submit_Hover_on);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRoot.ResumeLayout(false);
            this.panelRoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.Label lblNamePlaceHolder;
        private System.Windows.Forms.Label lblForgetPassword;
    }
}


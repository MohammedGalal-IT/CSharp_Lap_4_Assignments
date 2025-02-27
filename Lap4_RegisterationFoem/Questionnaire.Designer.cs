namespace Lap4_RegisterationFoem
{
    partial class frmQuestionnaire
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
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cbxComment = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuestionContainer = new System.Windows.Forms.Panel();
            this.fpnlRadioButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.pnlQuestionContainer.SuspendLayout();
            this.fpnlRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoot.Controls.Add(this.btnBack);
            this.pnlRoot.Controls.Add(this.btnSend);
            this.pnlRoot.Controls.Add(this.btnExit);
            this.pnlRoot.Controls.Add(this.btnHomePage);
            this.pnlRoot.Controls.Add(this.btnNext);
            this.pnlRoot.Controls.Add(this.txtComment);
            this.pnlRoot.Controls.Add(this.cbxComment);
            this.pnlRoot.Controls.Add(this.lblTitle);
            this.pnlRoot.Controls.Add(this.pnlQuestionContainer);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlRoot.Size = new System.Drawing.Size(593, 721);
            this.pnlRoot.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(186, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "السابق";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGray;
            this.btnSend.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(240, 548);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(39, 608);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.White;
            this.btnHomePage.Enabled = false;
            this.btnHomePage.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(396, 608);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(159, 40);
            this.btnHomePage.TabIndex = 4;
            this.btnHomePage.Text = "الصفحة الرئيسية";
            this.btnHomePage.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(295, 492);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "التالي";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Enabled = false;
            this.txtComment.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(48, 377);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(480, 75);
            this.txtComment.TabIndex = 3;
            // 
            // cbxComment
            // 
            this.cbxComment.AutoSize = true;
            this.cbxComment.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxComment.Location = new System.Drawing.Point(417, 347);
            this.cbxComment.Name = "cbxComment";
            this.cbxComment.Size = new System.Drawing.Size(100, 28);
            this.cbxComment.TabIndex = 2;
            this.cbxComment.Text = "إضافة تعليق";
            this.cbxComment.UseVisualStyleBackColor = true;
            this.cbxComment.CheckedChanged += new System.EventHandler(this.cbxComment_Changed);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(240, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(120, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "استبيان";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlQuestionContainer
            // 
            this.pnlQuestionContainer.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlQuestionContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionContainer.Controls.Add(this.fpnlRadioButtons);
            this.pnlQuestionContainer.Controls.Add(this.lblQuestion);
            this.pnlQuestionContainer.Location = new System.Drawing.Point(48, 78);
            this.pnlQuestionContainer.Name = "pnlQuestionContainer";
            this.pnlQuestionContainer.Size = new System.Drawing.Size(480, 247);
            this.pnlQuestionContainer.TabIndex = 2;
            // 
            // fpnlRadioButtons
            // 
            this.fpnlRadioButtons.Controls.Add(this.radioButton1);
            this.fpnlRadioButtons.Controls.Add(this.radioButton2);
            this.fpnlRadioButtons.Controls.Add(this.radioButton3);
            this.fpnlRadioButtons.Controls.Add(this.radioButton4);
            this.fpnlRadioButtons.Controls.Add(this.radioButton5);
            this.fpnlRadioButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlRadioButtons.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnlRadioButtons.Location = new System.Drawing.Point(238, 58);
            this.fpnlRadioButtons.Name = "fpnlRadioButtons";
            this.fpnlRadioButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fpnlRadioButtons.Size = new System.Drawing.Size(200, 186);
            this.fpnlRadioButtons.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ممتاز";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "جيد جدا";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(148, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 28);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "جيد";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(129, 105);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 28);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "مقبول";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(145, 139);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 28);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "سي";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(117, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuestion.Size = new System.Drawing.Size(358, 37);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "1-     كيف تجد جودة التعليم في جامعة تعز ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 721);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionnaire";
            this.Load += new System.EventHandler(this.frmQuestionnaire_Load);
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlQuestionContainer.ResumeLayout(false);
            this.pnlQuestionContainer.PerformLayout();
            this.fpnlRadioButtons.ResumeLayout(false);
            this.fpnlRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.FlowLayoutPanel fpnlRadioButtons;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlQuestionContainer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox cbxComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHomePage;
    }
}
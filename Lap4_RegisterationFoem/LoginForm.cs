using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lap4_RegisterationFoem
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Log In Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (re == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (ValidateForm.CheckTextEmpty(this.txtName.Text))
            {
                MessageBox.Show("Plese try agian");
            }
        }



        private void submit_Hover_on(object sender, EventArgs e)
        {
            this.lblSubmit.ForeColor = Color.LightBlue;
        }

        private void submit_Hover_leave(object sender, EventArgs e)
        {
            this.lblSubmit.ForeColor = Color.FromName("MenuHighLight");
        }

        private void lblOut_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (re == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void lblOut_Hover_on(object sender, MouseEventArgs e)
        {
            this.lblOut.ForeColor = Color.FromArgb(249, 169, 197);
        }

        private void lblOut_Hover_Leave(object sender, EventArgs e)
        {
            this.lblOut.ForeColor = Color.FromName("IndianRed");
        }

        private void cbxShowPassword_Checked(object sender, EventArgs e)
        {
            if (this.cbxShowPassword.Checked)
            {
                this.txtPassword.PasswordChar = (char)0;
                return;
            }
            this.txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Changed(object sender, EventArgs e)
        {

        }



        private void txtName_Changed(object sender, EventArgs e)
        {
            this.lblNamePlaceHolder.Hide();
            if (this.txtName.Text.Length == 0)
            {
                this.lblNamePlaceHolder.Show();



            }
        }

        private void txtEmail_Changed(object sender, EventArgs e)
        {
        }

        private void lblEmailPlaceHolder_Click(object sender, EventArgs e)
        {
        }

        private void lblNamePlaceHolder_Click(object sender, EventArgs e)
        {
            this.txtName.Focus();
        }



        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("This Feature will come soon", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lblForgetPassword_Move(object sender, MouseEventArgs e)
        {
            this.lblForgetPassword.ForeColor = Color.LightBlue;
        }



        private void lblForgetPassword_Leave(object sender, EventArgs e)
        {
            this.lblForgetPassword.ForeColor = Color.DodgerBlue;
        }
    }
}

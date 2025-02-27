using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lap4_RegisterationFoem
{

    public partial class frmSignUp : Form
    {
        //private readonly HttpClient _client = new HttpClient();
        //private const string ServerUrl = "http://localhost/Website//demo//CSharpConnect.php";
        public frmSignUp()
        {
            InitializeComponent();
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Account Created !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (re == DialogResult.OK)
            {
                this.Close();
            }
            // هذا الكود التالي هو فقط لتجربة ربط الواجة ب كود PHP 
            // Collect form data
            //var formData = new MultipartFormDataContent
            //{
            //    { new StringContent(txtName.Text), "name" },
            //    { new StringContent(txtEmail.Text), "email" }
            //};

            //try
            //{
            //    var response = await _client.PostAsync(ServerUrl, formData);
            //    var responseContent = await response.Content.ReadAsStringAsync();

            //    using (var responseForm = new ResponseForm(responseContent, response.IsSuccessStatusCode))
            //    {
            //        responseForm.ShowDialog();
            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    MessageBox.Show($"Request error: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}
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
                this.txtConfirmPassword.PasswordChar = (char)0;
                return;
            }
            this.txtPassword.PasswordChar = '*';
            this.txtConfirmPassword.PasswordChar = '*';
        }

        private void txtPassword_Changed(object sender, EventArgs e)
        {
            if (ValidateForm.IsPasswordStrong(this.txtPassword.Text))
            {
                this.lblPasswordStatus.Text = "قوية";
                this.lblPasswordStatus.ForeColor = Color.Green;
                this.lblPasswordStatus.Show();
                return;
            }
            this.lblPasswordStatus.Text = "ضعيفة";
            this.lblPasswordStatus.ForeColor = Color.IndianRed;
            this.lblPasswordStatus.Show();
        }



        private void txtName_Changed(object sender, EventArgs e)
        {
            this.lblNamePlaceHolder.Hide();
            if (this.txtName.Text.Length == 0)
            {
                this.lblNamePlaceHolder.Show();
                this.lblNamePlaceHolder.ForeColor = Color.IndianRed;


            }
        }

        private void txtEmail_Changed(object sender, EventArgs e)
        {
            this.lblEmailPlaceHolder.Hide();
            if (this.txtEmail.Text.Length == 0)
            {
                this.lblEmailPlaceHolder.Show();

            }
        }

        private void lblEmailPlaceHolder_Click(object sender, EventArgs e)
        {
            this.txtEmail.Focus();
        }

        private void lblNamePlaceHolder_Click(object sender, EventArgs e)
        {
            this.txtName.Focus();
        }
    }
}

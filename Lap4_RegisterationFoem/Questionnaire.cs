using System;
using System.Windows.Forms;

namespace Lap4_RegisterationFoem
{
    public partial class frmQuestionnaire : Form
    {
        public frmQuestionnaire()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxComment_Changed(object sender, EventArgs e)
        {
            if (this.cbxComment.Checked == true)
            {
                this.txtComment.Enabled = true;
                this.txtComment.Focus();
                return;
            }
            this.txtComment.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل ترغب في الخروج", "خروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (re == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("تم ارسال اجاباتك. ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmQuestionnaire_Load(object sender, EventArgs e)
        {

        }
    }
}

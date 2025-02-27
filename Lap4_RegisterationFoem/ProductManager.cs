using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap4_RegisterationFoem
{
    public partial class frmProductManager: Form
    {
        bool onChange = false;
        
        public frmProductManager()
        {
            InitializeComponent();
            this.cbxProductCategory.Items.AddRange(new object[] {
                "أجهزة الكترونية" ,
                "منتجات غذائية" ,
                "أدوات منزلية",
                "ملابس وأحذية" ,
                "منتجات أطفال" ,
                "منتجات طبية" ,
                "منتجات رياضية"
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string pName = this.txtProductName.Text;
            string pCategory = null;
            try
            {
                pCategory = this.cbxProductCategory.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                pCategory = "Not Selected";
            }

            this.lbxProducts.Items.Add($"{pName} - {pCategory}");

            this.txtProductName.Clear();
            this.cbxProductCategory.SelectedItem = null;

            if (onChange)
            {
                MessageBox.Show("تم تعديل العنصر بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                onChange = false;
                return;
            }
            MessageBox.Show("تم اضافة عنصر الى القائمة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lbxProducts_Click(object sender, EventArgs e)
        {
            if(this.lbxProducts.SelectedIndex != -1)
            {
                this.btnModifyProduct.Enabled = true;
                this.btnDeleteProduct.Enabled = true;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (this.lbxProducts.SelectedIndex == -1)
            {
                return;
            }
            this.lbxProducts.Items.RemoveAt(this.lbxProducts.SelectedIndex);
            this.btnModifyProduct.Enabled = false;
            this.btnDeleteProduct.Enabled = false;

            MessageBox.Show("تم حذف عنصر من القائمة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (this.lbxProducts.SelectedIndex == -1 || onChange)
            {
                return;
            }
            string s = this.lbxProducts.Items[this.lbxProducts.SelectedIndex].ToString();
            string[] arr = s.Split('-');
            this.txtProductName.Text = arr[0];

            switch (arr[1].Trim())
            {
                case "أجهزة الكترونية":
                    this.cbxProductCategory.SelectedIndex = 0;
                    break;

                case "منتجات غذائية":
                    this.cbxProductCategory.SelectedIndex = 1;
                    break;

                case "أدوات منزلية":
                    this.cbxProductCategory.SelectedIndex = 2;
                    break;

                case "ملابس وأحذية":
                    this.cbxProductCategory.SelectedIndex = 3;
                    break;
                case "منتجات أطفال":
                    this.cbxProductCategory.SelectedIndex = 4;
                    break;

                case "منتجات طبية":
                    this.cbxProductCategory.SelectedIndex = 5;
                    break;

                case "منتجات رياضية":
                    this.cbxProductCategory.SelectedIndex = 6;
                    break;

            }

            this.lbxProducts.Items.RemoveAt(this.lbxProducts.SelectedIndex);
            this.btnModifyProduct.Enabled = false;
            this.btnDeleteProduct.Enabled = false;

            onChange = true;
        }
    }
}

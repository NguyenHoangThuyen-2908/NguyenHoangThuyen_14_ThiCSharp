using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangThuyen_14_ThiCSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hovaten = "Nguyễn Hoàng Thuyên";
            string mssv = "1223360205";
            string monthi = "Lập trình Window 2 - C#";

            lblsv.Text = "Họ và Tên: " + hovaten;
            lblsv.Text += "\n MSSV: " + mssv;
            lblsv.Text += "\n Ngày thi:" + System.DateTime.Now.ToString();
            lblsv.Text += "\n Môn thi: " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông Tin");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiaiptbac2 frmgiaiptbac2 = new frmgiaiptbac2();
            frmgiaiptbac2.Show();

        }
    }
}

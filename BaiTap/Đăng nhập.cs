using BaiTap.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
  
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var user = txtDN.Text;
            var pass = txtMK.Text;
            TaiKhoan taikhoan;
            taikhoan = TaiKhoan.Get(user, pass);

            if (taikhoan == null)
            {
                MessageBox.Show($"Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show($"Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show($"Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}

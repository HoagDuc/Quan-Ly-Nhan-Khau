using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class FormHomeUser : Form
    {
        FormHome cur_frmhome;
        FormLogin cur_frmlogin;
        public FormHomeUser(FormLogin frmlogin)
        {
            cur_frmlogin = frmlogin;
            InitializeComponent();
        }

        private void btnQLPhuong_Click(object sender, EventArgs e)
        {
            FormPhuong frmPhuong = new FormPhuong(cur_frmhome);
            frmPhuong.Show();
        }

        private void btnQLNhanKhau_Click(object sender, EventArgs e)
        {
            FormNhanKhau frmNK = new FormNhanKhau(cur_frmhome);
            frmNK.Show();
        }

        private void btnQLTDP_Click(object sender, EventArgs e)
        {
            FormToDanPho frmTDP = new FormToDanPho(cur_frmhome);
            frmTDP.Show();
        }

        private void btnQLNPT_Click(object sender, EventArgs e)
        {
            FormNPT frmNPT = new FormNPT(cur_frmhome);
            frmNPT.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không ? ", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                cur_frmlogin.Show();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormAccount f = new FormAccount();
            f.Show();
        }

        private void btnAccouontManager_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền truy cập ! ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormHomeUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class FormHome : Form
    {
        FormLogin cur_frmlogin;
        public FormHome(FormLogin frmlogin)
        {
            cur_frmlogin = frmlogin;
            InitializeComponent();
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

        private void btnQLNhanKhau_Click(object sender, EventArgs e)
        {
            FormNhanKhau frmNK = new FormNhanKhau(this);
            frmNK.Show();
                       
        }

        private void btnQLPhuong_Click(object sender, EventArgs e)
        {
            FormPhuong frmPhuong = new FormPhuong(this);
            frmPhuong.Show();
            
        }

        private void btnQLTDP_Click(object sender, EventArgs e)
        {
            FormToDanPho frmTDP = new FormToDanPho(this);
            frmTDP.Show();
            
        }

        private void btnQLNPT_Click(object sender, EventArgs e)
        {
            FormNPT frmNPT = new FormNPT(this);
            frmNPT.Show();
            
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormAccount f = new FormAccount();
            f.Show();
        }

        private void btnAccouontManager_Click(object sender, EventArgs e)
        {
            FormAccountManager f = new FormAccountManager();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

}

using QuanLyPhuKienDienTu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuKienDienTu.View
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            LoadTaiKhoan();

        }

        private void LoadTaiKhoan()
        {
            dataGridView1.DataSource = BLL_TaiKhoan_View.Instance.GetTaiKhoan();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan form = new FormThemTaiKhoan();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}

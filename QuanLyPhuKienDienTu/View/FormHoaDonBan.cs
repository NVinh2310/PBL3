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
    public partial class FormHoaDonBan : Form
    {
        public FormHoaDonBan()
        {
            InitializeComponent();
            LoadDaTa();
        }

        private void LoadDaTa()
        {
            dataGridView1.DataSource = BLL_ThongTinBan.Instance.HoaDonBan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

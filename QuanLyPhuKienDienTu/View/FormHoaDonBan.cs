using QuanLyPhuKienDienTu.BLL;
using QuanLyPhuKienDienTu.DTO;
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
            dataGridView.DataSource = BLL_ThongTinBan.Instance.HoaDonBan();
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadDaTa();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;

            List<ThongTinBan> data = new List<ThongTinBan>();

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                ThongTinBan info = item.DataBoundItem as ThongTinBan;
                data.Add(info);
            }

            dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoNgay(data, dateTime);
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}

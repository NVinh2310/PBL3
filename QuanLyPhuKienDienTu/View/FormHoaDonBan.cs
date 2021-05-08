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
            SetCBBLoaiTimKiem();
        }

        private void LoadDaTa()
        {
            dataGridView.DataSource = BLL_ThongTinBan.Instance.HoaDonBan();
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }

        private void SetCBBLoaiTimKiem()
        {
            cbbDate.Items.AddRange(new string[] { "Ngày", "Tháng", "Năm" });
            cbbDate.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadDaTa();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            string type = cbbDate.Text;

            switch (type)
            {
                case "Ngày":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoNgay(dateTime);
                    break;
                case "Tháng":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoThang(dateTime);
                    break;
                case "Năm":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoNam(dateTime);
                    break;
                default:
                    MessageBox.Show("Không hợp lệ");
                    break;
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;

            if (Process.IsEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên muốn tìm");
                return;
            }

            dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoTen(name);
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

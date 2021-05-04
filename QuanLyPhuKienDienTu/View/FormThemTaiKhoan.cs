using QuanLyPhuKienDienTu.BLL;
using QuanLyPhuKienDienTu.DAO;
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

namespace QuanLyPhuKienDienTu
{
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            SetCBB();
        }

        private void SetCBB()
        {
            List<NhanVien> list = BLL_NhanVien.Instance.GetNhanVien();

            foreach(NhanVien item in list)
            {
                cbbName.Items.Add(new CBBItem
                {
                    Value = item.MaNhanVien,
                    Text = item.TenNhanVien
                });
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Trường hợp các dữ liệu đầu vào trống 
            if (Process.IsEmpty(cbbName.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên để thêm tài khoản");
                return;
            }

            if (Process.IsEmpty(txbUsername.Text) || 
                Process.IsEmpty(txbPassword.Text) || 
                Process.IsEmpty(txbSubmitPas.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin");
                return;
            }

            //Nhập lại mật khẩu không khớp
            if (!txbPassword.Text.Equals(txbSubmitPas.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
                return;
            }

            //Lỗi tự nhập combobox bị sai. Cần xử lý Exception
            //Thêm tài khoản thành công


            //////////////
        }

        private void ResetData()
        {
            cbbName.Text = "";
            txbUsername.Text = "";
            txbPassword.Text = "";
            txbSubmitPas.Text = "";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
            LoadNameIntoComboBox();
        }

        private void LoadNameIntoComboBox()
        {
            List<Staff> staffs = StaffDAO.Instance.GetStaffs();
            List<Account> accounts = AccountDAO.Instance.GetAccounts();
            var result = from staff in staffs
                         where !(from account in accounts
                                 select account.IDStaff)
                                .Contains(staff.ID)
                         select new
                         {
                             id = staff.ID,
                             name = staff.Name
                         };

            comboBoxName.DataSource = result.ToList();
            comboBoxName.DisplayMember = "name";
            comboBoxName.ValueMember = "id";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxName.SelectedValue);
            if (id == 0)
            {
                MessageBox.Show("Dữ liệu nhân viên không hợp lệ ! Vui lòng chọn lại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = usernameTxb.Text;
                string password = passwordTxb.Text;
                string submitPass = submitPasTxb.Text;
                if (password != submitPass)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!AccountDAO.Instance.UsernameAvailable(username)) {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (AccountDAO.Instance.InsertAccount(id, username, password))
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNameIntoComboBox();
                        ResetData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetData()
        {
            comboBoxName.Text = "";
            usernameTxb.Text = "";
            passwordTxb.Text = "";
            submitPasTxb.Text = "";
        }
    }
}

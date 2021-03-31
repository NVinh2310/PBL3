using QuanLyPhuKienDienTu.DAO;
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
    public partial class ModifyPasswordForm : Form
    {
        public ModifyPasswordForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            int id = AccountDAO.Instance.GetID(username, password);
            if (id != -100)
            {
                string newPassword = textBoxNewPassword.Text;
                if (AccountDAO.Instance.ModifyPassword(id, newPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Khong hop le");
            }
        }
    }
}

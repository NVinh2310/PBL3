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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            LoadAccountToListView();
        }

        private void LoadAccountToListView()
        {
            List<Account> accounts = AccountDAO.Instance.GetAccounts();
            List<Staff> staffs = StaffDAO.Instance.GetStaffs();

            var result = from account in accounts
                         join staff in staffs on account.IDStaff equals staff.ID
                         select new
                         {
                             id = staff.ID,
                             name = staff.Name,
                             username = account.Username,
                             status = staff.Status
                         };

            foreach (var item in result)
            {
                ListViewItem listView = new ListViewItem(item.name);
                listView.SubItems.Add(item.username);
                listView.SubItems.Add((item.status == 1) ? "Quản lý" : "Nhân viên");

                listViewAccount.Items.Add(listView);
            }
        }

        private void listViewProductEntry_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem index = listViewAccount.SelectedItems[0];

            MessageBox.Show(index.SubItems[0].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            listViewAccount.Items.Clear();
            LoadAccountToListView();
        }
    }
}

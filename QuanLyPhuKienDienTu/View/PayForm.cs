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
    public partial class PayForm : Form
    {
        public List<ListViewItem> ListViewItems { get; set; }
        public  delegate void Mydel();
        public Mydel MD { get; set; }
        public PayForm(List<ListViewItem> m)
        {
            ListViewItems = m;
            InitializeComponent();
            LoadListView();

        }
        public void LoadListView()
        {
            Decimal TongGiaBan = 0;
            foreach (ListViewItem i in ListViewItems)
            { 
                listView1.Items.Add(i);
                TongGiaBan += Convert.ToDecimal(i.SubItems[3].Text);
            }
            textBoxPrice.Text = TongGiaBan.ToString();
        }

        

        private void payButton_Click(object sender, EventArgs e)
        {
            // Bill mới, chưa có món
            // Bill cũ, chưa có món cần thêm
            // Bill cũ, đã có món cần thêm( Cập nhật lại số lượng)
           // ChiTiet ctb = new ChiTiet();
            //int a = BLL.BLL_HoaDonBan.Instance.GetMaHoaDonMax() ;
            //foreach(ListViewItem i in listView1.Items)
            //{

            //    MessageBox.Show();
            //}
            //int Slg = Convert.ToInt32(numericSoLuongBan.Value);


            //if (listView1.Items.Count == 0)
            //{
            //    //DAO.DAO_HoaDonBan.Instance.AddHoaDonBan(1, DateTime.Now);
            //    //a++;
            //    //DAO.DAO_HoaDonBanChiTiet.Instance.AddHoaDonBanChiTiet(a, MSP, Slg, "New");
            //    //ShowChiTietHoaDonBa(11);
            //}
            //else if (listView1.Items.Count != 0 && check(MSP) == false)
            //{
                DAO.DAO_HoaDonBanChiTiet.Instance.AddHoaDonBanChiTiet(1,1, 5, "New nè");
            //    MessageBox.Show("Thêm moi");

            //}
            //else if (listView1.Items.Count != 0 && check(MSP) == true)
            //{
            //    DAO.DAO_HoaDonBanChiTiet.Instance.UpdateHoaDonBanChiTiet();
            //    MessageBox.Show("Cập nhật số lg hehe");
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

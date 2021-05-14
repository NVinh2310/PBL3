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
    public partial class MainForm : Form
    {
        public List<SanPham> listPaySanPham { get; set; }

        public MainForm()
        {
            InitializeComponent();
            setComboBox();
            show();
            LoadSanPhamView();
        }
        #region Method
        private void setComboBox()
        {
            comboBoxLoai.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });
            comboBoxHang.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });

            foreach (Loai i in BLL.BLL_Loai.Instance.GetListLoai())
            {
                comboBoxLoai.Items.Add(new CBBItem
                {
                    Value = i.MaLoai,
                    Text = i.TenLoai
                });
            }
            comboBoxLoai.SelectedIndex = 0;

            foreach (ThuongHieu i in BLL.BLL_ThuongHieu.Instance.GetListThuongHieu())
            {
                comboBoxHang.Items.Add(new CBBItem
                {
                    Value = i.MaThuongHieu,
                    Text = i.TenThuongHieu
                });
            }
            comboBoxHang.SelectedIndex = 0;
            comboBoxGia.SelectedIndex = 0;
        }
        public void show()
        {
            dataGridView1.DataSource = BLL.BLL_SanPham.Instance.GetSanPham_Views("All", "All", "All", "All");
            SetShow();

        }
        public void SetShow()
        {
            dataGridView1.Columns["MoTa"].Visible = false;
            dataGridView1.Columns["MaSanPham"].Visible = false;
            dataGridView1.Columns["MauSac"].Visible = false;
            dataGridView1.Columns["ThoiLuongBaoHanh"].Visible = false;
        }
        public void LoadSanPhamView()
        {
            textBoxTenSp.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSanPham"));
            textBoxThuongHieu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenThuongHieu"));
            textBoxLoai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenLoai"));
            textBoxMau.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MauSac"));
            textBoxThoiLuongBH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ThoiLuongBaoHanh"));
            textBoxGiaBan.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GiaBan"));
            textBoxSoLuongTon.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuongTonKho"));
            labelMoTa.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MoTa"));
        }

        public void ShowChiTietHoaDonBa(int a)
        {
            List<ChiTietBan> list = BLL.BLL_ThongTinBan.Instance.ThongTinSanPham(a);
            decimal TongTienHoaDon =0;

            foreach (ChiTietBan i in list)
            {
                ListViewItem listView = new ListViewItem(i.TenSanPham) { Tag = i};
                listView.SubItems.Add(i.SoLuongBan.ToString());
                listView.SubItems.Add(i.GiaBan.ToString());
                listView.SubItems.Add((i.GiaBan * i.SoLuongBan).ToString());
                listView.Tag = i;
                TongTienHoaDon += (Decimal)(i.GiaBan * i.SoLuongBan);
                listView1.Items.Add(listView);
            }
                textBoxPayment.Text = TongTienHoaDon.ToString();

        }
        public int check(int MSP)
        {
            foreach (ListViewItem i in listView1.Items)
            {
                if (i.Text == BLL.BLL_SanPham.Instance.GetSanPhamByID(MSP).TenSanPham)
                    return i.Index;
            }
            return -100;
        }
        public void AddListView()
        {
            
            int a= Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString());
            int index = check(a);
            SanPham_View i =BLL.BLL_SanPham.Instance.GetSanPhamByID(a);
            decimal TongTienHoaDon = 0;
            int SoLuongBan = Convert.ToInt32(numericSoLuongBan.Value);

            if(index!= -100)
            {

                int SLgSau = 0;
                int SLgTruoc = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);
                SLgSau = SLgTruoc + Convert.ToInt32(numericSoLuongBan.Value);
                Decimal GiaBan = Convert.ToDecimal(listView1.Items[index].SubItems[2].Text);
                listView1.Items[index].SubItems[1].Text = SLgSau.ToString();
                listView1.Items[index].SubItems[3].Text = ((SLgSau * GiaBan).ToString());
                TongTienHoaDon = Convert.ToDecimal(textBoxPayment.Text) +(SLgSau * GiaBan);
                textBoxPayment.Text = TongTienHoaDon.ToString();
            }    
            else
            {
                ListViewItem listView = new ListViewItem(i.TenSanPham);
                listView.SubItems.Add(numericSoLuongBan.Value.ToString());
                listView.SubItems.Add(i.GiaBan.ToString());
                listView.SubItems.Add((i.GiaBan * SoLuongBan).ToString());
                TongTienHoaDon += (Decimal)(i.GiaBan * SoLuongBan);
                listView1.Items.Add(listView);
                textBoxPayment.Text = TongTienHoaDon.ToString();
            }    

        }

        public void DeleteListView()
        {
            string tensp =listView1.SelectedItems[0].SubItems[0].Text;
            int SLgSau = 0;
            int SLgTruoc = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
            SLgSau = SLgTruoc - Convert.ToInt32(numericSoLuongBan.Value);
            if(SLgSau <1)
            {
                Decimal TongTienHoaDon = Convert.ToDecimal(textBoxPayment.Text) - Convert.ToDecimal(listView1.SelectedItems[0].SubItems[3].Text);
                listView1.SelectedItems[0].Remove();
                textBoxPayment.Text = TongTienHoaDon.ToString();
            }    
            else
            {
                Decimal GiaBan = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[2].Text);
                listView1.SelectedItems[0].SubItems[1].Text = SLgSau.ToString();
                listView1.SelectedItems[0].SubItems[3].Text = ((SLgSau * GiaBan ).ToString());
                Decimal TongTienHoaDon = Convert.ToDecimal(textBoxPayment.Text) - (SLgSau * GiaBan);
                textBoxPayment.Text = TongTienHoaDon.ToString();
            }    

        }

        #endregion





        #region Event
        private void buttonTim_Click(object sender, EventArgs e)
        {
            string loai = comboBoxLoai.SelectedItem.ToString();
            string thuonghieu = comboBoxHang.SelectedItem.ToString();
            string gia = comboBoxGia.SelectedItem.ToString();

            dataGridView1.DataSource = BLL.BLL_SanPham.Instance.GetSanPham_Views(textBoxTim.Text, loai, thuonghieu, gia);
            SetShow();

        }
        
        
        private void buttonThem_Click(object sender, EventArgs e)
        {
            
            AddListView();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            foreach (ListViewItem i in listView1.Items)
            {
                ListViewItem x = new ListViewItem(i.SubItems[0].Text);
                x.SubItems.Add(i.SubItems[1].Text);
                x.SubItems.Add(i.SubItems[2].Text);
                x.SubItems.Add(i.SubItems[3].Text);
                listViewItems.Add(x);
            }
            PayForm pf = new PayForm(listViewItems);
            pf.Show();

        }
        #endregion

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count!=0&& listView1.SelectedItems.Count !=0)
            {
                DeleteListView();
            }    
        }
    }
}

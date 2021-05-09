
namespace QuanLyPhuKienDienTu.View
{
    partial class FormSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtmausac = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbthuonghieu = new System.Windows.Forms.ComboBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbloai);
            this.groupBox1.Controls.Add(this.cbbthuonghieu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txtmausac);
            this.groupBox1.Controls.Add(this.txttensp);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(137, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(234, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(331, 191);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(428, 191);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(695, 200);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(539, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 8;
            // 
            // txtmota
            // 
            this.txtmota.Enabled = false;
            this.txtmota.Location = new System.Drawing.Point(375, 107);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(103, 22);
            this.txtmota.TabIndex = 9;
            // 
            // txtmausac
            // 
            this.txtmausac.Enabled = false;
            this.txtmausac.Location = new System.Drawing.Point(375, 71);
            this.txtmausac.Name = "txtmausac";
            this.txtmausac.Size = new System.Drawing.Size(103, 22);
            this.txtmausac.TabIndex = 10;
            // 
            // txttensp
            // 
            this.txttensp.Enabled = false;
            this.txttensp.Location = new System.Drawing.Point(375, 36);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(139, 22);
            this.txttensp.TabIndex = 11;
            // 
            // txtmasp
            // 
            this.txtmasp.Enabled = false;
            this.txtmasp.Location = new System.Drawing.Point(146, 36);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(105, 22);
            this.txtmasp.TabIndex = 14;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Enabled = false;
            this.txtgianhap.Location = new System.Drawing.Point(608, 64);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(139, 22);
            this.txtgianhap.TabIndex = 15;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Enabled = false;
            this.txtgiaban.Location = new System.Drawing.Point(608, 36);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(139, 22);
            this.txtgiaban.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(608, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Thương Hiệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Màu Sắc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mô Tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá Bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Giá Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bảo Hành";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 18);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(770, 172);
            this.dgvSanPham.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(608, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "SL Tồn Kho";
            // 
            // cbbthuonghieu
            // 
            this.cbbthuonghieu.Enabled = false;
            this.cbbthuonghieu.FormattingEnabled = true;
            this.cbbthuonghieu.Location = new System.Drawing.Point(146, 70);
            this.cbbthuonghieu.Name = "cbbthuonghieu";
            this.cbbthuonghieu.Size = new System.Drawing.Size(105, 24);
            this.cbbthuonghieu.TabIndex = 29;
            // 
            // cbbloai
            // 
            this.cbbloai.Enabled = false;
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(146, 105);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(105, 24);
            this.cbbloai.TabIndex = 30;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtmausac;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.ComboBox cbbthuonghieu;
    }
}
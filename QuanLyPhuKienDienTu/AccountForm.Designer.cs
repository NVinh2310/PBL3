namespace QuanLyPhuKienDienTu
{
    partial class AccountForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.listViewAccount = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.Color.Tomato;
            this.addBtn.Location = new System.Drawing.Point(496, 30);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(33, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewAccount
            // 
            this.listViewAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAccount.FullRowSelect = true;
            this.listViewAccount.GridLines = true;
            this.listViewAccount.HideSelection = false;
            this.listViewAccount.Location = new System.Drawing.Point(60, 73);
            this.listViewAccount.Name = "listViewAccount";
            this.listViewAccount.Size = new System.Drawing.Size(510, 352);
            this.listViewAccount.TabIndex = 38;
            this.listViewAccount.UseCompatibleStateImageBehavior = false;
            this.listViewAccount.View = System.Windows.Forms.View.Details;
            this.listViewAccount.DoubleClick += new System.EventHandler(this.listViewProductEntry_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chức vụ";
            this.columnHeader4.Width = 116;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.Tomato;
            this.deleteBtn.Location = new System.Drawing.Point(537, 30);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(33, 35);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "-";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 462);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listViewAccount);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView listViewAccount;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
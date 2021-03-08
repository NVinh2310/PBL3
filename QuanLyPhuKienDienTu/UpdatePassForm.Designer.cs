
namespace QuanLyPhuKienDienTu
{
    partial class UpdatePassForm
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
            this.Savebutton = new System.Windows.Forms.Button();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Savebutton
            // 
            this.Savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebutton.Location = new System.Drawing.Point(421, 257);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(99, 45);
            this.Savebutton.TabIndex = 34;
            this.Savebutton.Text = "Lưu";
            this.Savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(200, 202);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(320, 28);
            this.textBoxPassword2.TabIndex = 33;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 143);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(320, 28);
            this.textBoxPassword.TabIndex = 32;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên tài khoản:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(200, 83);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(320, 28);
            this.textBoxUsername.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // UpdatePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdatePassForm";
            this.Text = "UpdatePassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
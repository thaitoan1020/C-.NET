namespace QLCSDT
{
    partial class f_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DN = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_pass = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_DN = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_DN);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Location = new System.Drawing.Point(5, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 42);
            this.panel1.TabIndex = 0;
            // 
            // txt_DN
            // 
            this.txt_DN.Location = new System.Drawing.Point(151, 14);
            this.txt_DN.Name = "txt_DN";
            this.txt_DN.Size = new System.Drawing.Size(226, 21);
            this.txt_DN.TabIndex = 1;
            this.txt_DN.Text = "Toan";
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(13, 16);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 19);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Pass);
            this.panel2.Controls.Add(this.btn_pass);
            this.panel2.Location = new System.Drawing.Point(5, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 42);
            this.panel2.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(151, 12);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(226, 21);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.Text = "1";
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // btn_pass
            // 
            this.btn_pass.AutoSize = true;
            this.btn_pass.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pass.Location = new System.Drawing.Point(13, 12);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(86, 19);
            this.btn_pass.TabIndex = 0;
            this.btn_pass.Text = "Mật khẩu:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Location = new System.Drawing.Point(12, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 121);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // btn_DN
            // 
            this.btn_DN.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Appearance.Options.UseFont = true;
            this.btn_DN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_DN.Location = new System.Drawing.Point(155, 153);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(122, 43);
            this.btn_DN.TabIndex = 5;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_exit.Location = new System.Drawing.Point(283, 153);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 43);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // f_DangNhap
            // 
            this.AcceptButton = this.btn_DN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 210);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_DN_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_DN;
        private System.Windows.Forms.Label btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label btn_pass;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DN;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
    }
}


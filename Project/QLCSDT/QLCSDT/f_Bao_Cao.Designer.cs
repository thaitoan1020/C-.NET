namespace QLCSDT
{
    partial class f_Bao_Cao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rp_HocPhi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rp_LNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rp_LGV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rp_DSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rp_DSNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.rp_DSGV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NewHocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCSDTDataSet = new QLCSDT.QLCSDTDataSet();
            this.HocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HocPhiTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.HocPhiTableAdapter();
            this.NewHocPhiTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.NewHocPhiTableAdapter();
            this.NewBanLuongNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewBanLuongNVTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.NewBanLuongNVTableAdapter();
            this.NewBanLuongGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewBanLuongGVTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.NewBanLuongGVTableAdapter();
            this.HocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HocSinhTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.HocSinhTableAdapter();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.NhanVienTableAdapter();
            this.GiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GiaoVienTableAdapter = new QLCSDT.QLCSDTDataSetTableAdapters.GiaoVienTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewHocPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCSDTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBanLuongNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBanLuongGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rp_HocPhi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Học Phí";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rp_HocPhi
            // 
            this.rp_HocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NewHocPhiBindingSource;
            this.rp_HocPhi.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_HocPhi.LocalReport.ReportEmbeddedResource = "QLCSDT.rpw_HocPhi.rdlc";
            this.rp_HocPhi.Location = new System.Drawing.Point(3, 3);
            this.rp_HocPhi.Name = "rp_HocPhi";
            this.rp_HocPhi.ServerReport.BearerToken = null;
            this.rp_HocPhi.Size = new System.Drawing.Size(783, 415);
            this.rp_HocPhi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rp_LNV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lương nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rp_LNV
            // 
            this.rp_LNV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.NewBanLuongNVBindingSource;
            this.rp_LNV.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_LNV.LocalReport.ReportEmbeddedResource = "QLCSDT.rpw_LuongNhanVien.rdlc";
            this.rp_LNV.Location = new System.Drawing.Point(3, 3);
            this.rp_LNV.Name = "rp_LNV";
            this.rp_LNV.ServerReport.BearerToken = null;
            this.rp_LNV.Size = new System.Drawing.Size(783, 415);
            this.rp_LNV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rp_LGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lương giáo viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rp_LGV
            // 
            this.rp_LGV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.NewBanLuongGVBindingSource;
            this.rp_LGV.LocalReport.DataSources.Add(reportDataSource3);
            this.rp_LGV.LocalReport.ReportEmbeddedResource = "QLCSDT.rpw_BanLuongGV.rdlc";
            this.rp_LGV.Location = new System.Drawing.Point(3, 3);
            this.rp_LGV.Name = "rp_LGV";
            this.rp_LGV.ServerReport.BearerToken = null;
            this.rp_LGV.Size = new System.Drawing.Size(783, 415);
            this.rp_LGV.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rp_DSHS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh sách Học Sinh";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rp_DSHS
            // 
            this.rp_DSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.HocSinhBindingSource;
            this.rp_DSHS.LocalReport.DataSources.Add(reportDataSource4);
            this.rp_DSHS.LocalReport.ReportEmbeddedResource = "QLCSDT.rpw_DSHS.rdlc";
            this.rp_DSHS.Location = new System.Drawing.Point(3, 3);
            this.rp_DSHS.Name = "rp_DSHS";
            this.rp_DSHS.ServerReport.BearerToken = null;
            this.rp_DSHS.Size = new System.Drawing.Size(783, 415);
            this.rp_DSHS.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rp_DSNV);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(789, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Danh sách Nhân viên";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rp_DSNV
            // 
            this.rp_DSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.NhanVienBindingSource;
            this.rp_DSNV.LocalReport.DataSources.Add(reportDataSource5);
            this.rp_DSNV.LocalReport.ReportEmbeddedResource = "QLCSDT.rpw_DSNV.rdlc";
            this.rp_DSNV.Location = new System.Drawing.Point(3, 3);
            this.rp_DSNV.Name = "rp_DSNV";
            this.rp_DSNV.ServerReport.BearerToken = null;
            this.rp_DSNV.Size = new System.Drawing.Size(783, 415);
            this.rp_DSNV.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.rp_DSGV);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(789, 421);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Danh sách Giáo viên";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // rp_DSGV
            // 
            this.rp_DSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.GiaoVienBindingSource;
            this.rp_DSGV.LocalReport.DataSources.Add(reportDataSource6);
            this.rp_DSGV.LocalReport.ReportEmbeddedResource = "QLCSDT.DSGV.rdlc";
            this.rp_DSGV.Location = new System.Drawing.Point(3, 3);
            this.rp_DSGV.Name = "rp_DSGV";
            this.rp_DSGV.ServerReport.BearerToken = null;
            this.rp_DSGV.Size = new System.Drawing.Size(783, 415);
            this.rp_DSGV.TabIndex = 0;
            // 
            // NewHocPhiBindingSource
            // 
            this.NewHocPhiBindingSource.DataMember = "NewHocPhi";
            this.NewHocPhiBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // QLCSDTDataSet
            // 
            this.QLCSDTDataSet.DataSetName = "QLCSDTDataSet";
            this.QLCSDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HocPhiBindingSource
            // 
            this.HocPhiBindingSource.DataMember = "HocPhi";
            this.HocPhiBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // HocPhiTableAdapter
            // 
            this.HocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // NewHocPhiTableAdapter
            // 
            this.NewHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // NewBanLuongNVBindingSource
            // 
            this.NewBanLuongNVBindingSource.DataMember = "NewBanLuongNV";
            this.NewBanLuongNVBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // NewBanLuongNVTableAdapter
            // 
            this.NewBanLuongNVTableAdapter.ClearBeforeFill = true;
            // 
            // NewBanLuongGVBindingSource
            // 
            this.NewBanLuongGVBindingSource.DataMember = "NewBanLuongGV";
            this.NewBanLuongGVBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // NewBanLuongGVTableAdapter
            // 
            this.NewBanLuongGVTableAdapter.ClearBeforeFill = true;
            // 
            // HocSinhBindingSource
            // 
            this.HocSinhBindingSource.DataMember = "HocSinh";
            this.HocSinhBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // HocSinhTableAdapter
            // 
            this.HocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoVienBindingSource
            // 
            this.GiaoVienBindingSource.DataMember = "GiaoVien";
            this.GiaoVienBindingSource.DataSource = this.QLCSDTDataSet;
            // 
            // GiaoVienTableAdapter
            // 
            this.GiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // f_Bao_Cao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_Bao_Cao";
            this.Text = "f_Bao_Cao";
            this.Load += new System.EventHandler(this.f_Bao_Cao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewHocPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCSDTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBanLuongNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBanLuongGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.BindingSource HocPhiBindingSource;
        private QLCSDTDataSet QLCSDTDataSet;
        private QLCSDTDataSetTableAdapters.HocPhiTableAdapter HocPhiTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rp_HocPhi;
        private Microsoft.Reporting.WinForms.ReportViewer rp_DSGV;
        private Microsoft.Reporting.WinForms.ReportViewer rp_DSNV;
        private Microsoft.Reporting.WinForms.ReportViewer rp_DSHS;
        private Microsoft.Reporting.WinForms.ReportViewer rp_LGV;
        private Microsoft.Reporting.WinForms.ReportViewer rp_LNV;
        private System.Windows.Forms.BindingSource NewHocPhiBindingSource;
        private QLCSDTDataSetTableAdapters.NewHocPhiTableAdapter NewHocPhiTableAdapter;
        private System.Windows.Forms.BindingSource NewBanLuongNVBindingSource;
        private QLCSDTDataSetTableAdapters.NewBanLuongNVTableAdapter NewBanLuongNVTableAdapter;
        private System.Windows.Forms.BindingSource NewBanLuongGVBindingSource;
        private QLCSDTDataSetTableAdapters.NewBanLuongGVTableAdapter NewBanLuongGVTableAdapter;
        private System.Windows.Forms.BindingSource HocSinhBindingSource;
        private QLCSDTDataSetTableAdapters.HocSinhTableAdapter HocSinhTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private QLCSDTDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource GiaoVienBindingSource;
        private QLCSDTDataSetTableAdapters.GiaoVienTableAdapter GiaoVienTableAdapter;
    }
}
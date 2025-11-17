namespace SyllabusManagement
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteGv = new System.Windows.Forms.Button();
            this.btnEditGv = new System.Windows.Forms.Button();
            this.btnAddGv = new System.Windows.Forms.Button();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.txtGvPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGvUsername = new System.Windows.Forms.TextBox();
            this.txtGvEmail = new System.Windows.Forms.TextBox();
            this.txtGvFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReportByLecturer = new System.Windows.Forms.Button();
            this.btnReportByCourse = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 578);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteGv);
            this.tabPage1.Controls.Add(this.btnEditGv);
            this.tabPage1.Controls.Add(this.btnAddGv);
            this.tabPage1.Controls.Add(this.dgvGiangVien);
            this.tabPage1.Controls.Add(this.txtGvPassword);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtGvUsername);
            this.tabPage1.Controls.Add(this.txtGvEmail);
            this.tabPage1.Controls.Add(this.txtGvFullName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý giảng viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGv
            // 
            this.btnDeleteGv.Location = new System.Drawing.Point(636, 80);
            this.btnDeleteGv.Name = "btnDeleteGv";
            this.btnDeleteGv.Size = new System.Drawing.Size(99, 43);
            this.btnDeleteGv.TabIndex = 11;
            this.btnDeleteGv.Text = "Xóa";
            this.btnDeleteGv.UseVisualStyleBackColor = true;
            this.btnDeleteGv.Click += new System.EventHandler(this.btnDeleteGv_Click);
            // 
            // btnEditGv
            // 
            this.btnEditGv.Location = new System.Drawing.Point(769, 20);
            this.btnEditGv.Name = "btnEditGv";
            this.btnEditGv.Size = new System.Drawing.Size(100, 44);
            this.btnEditGv.TabIndex = 10;
            this.btnEditGv.Text = "Sửa";
            this.btnEditGv.UseVisualStyleBackColor = true;
            this.btnEditGv.Click += new System.EventHandler(this.btnEditGv_Click);
            // 
            // btnAddGv
            // 
            this.btnAddGv.Location = new System.Drawing.Point(636, 20);
            this.btnAddGv.Name = "btnAddGv";
            this.btnAddGv.Size = new System.Drawing.Size(99, 44);
            this.btnAddGv.TabIndex = 9;
            this.btnAddGv.Text = "Thêm";
            this.btnAddGv.UseVisualStyleBackColor = true;
            this.btnAddGv.Click += new System.EventHandler(this.btnAddGv_Click);
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Location = new System.Drawing.Point(34, 169);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(835, 356);
            this.dgvGiangVien.TabIndex = 8;
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // txtGvPassword
            // 
            this.txtGvPassword.Location = new System.Drawing.Point(459, 99);
            this.txtGvPassword.Name = "txtGvPassword";
            this.txtGvPassword.Size = new System.Drawing.Size(157, 24);
            this.txtGvPassword.TabIndex = 7;
            this.txtGvPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu:";
            // 
            // txtGvUsername
            // 
            this.txtGvUsername.Location = new System.Drawing.Point(459, 30);
            this.txtGvUsername.Name = "txtGvUsername";
            this.txtGvUsername.Size = new System.Drawing.Size(157, 24);
            this.txtGvUsername.TabIndex = 5;
            // 
            // txtGvEmail
            // 
            this.txtGvEmail.Location = new System.Drawing.Point(118, 99);
            this.txtGvEmail.Name = "txtGvEmail";
            this.txtGvEmail.Size = new System.Drawing.Size(233, 24);
            this.txtGvEmail.TabIndex = 4;
            // 
            // txtGvFullName
            // 
            this.txtGvFullName.Location = new System.Drawing.Point(118, 30);
            this.txtGvFullName.Name = "txtGvFullName";
            this.txtGvFullName.Size = new System.Drawing.Size(233, 24);
            this.txtGvFullName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên GV:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReportByLecturer);
            this.tabPage2.Controls.Add(this.btnReportByCourse);
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.dgvReport);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReportByLecturer
            // 
            this.btnReportByLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportByLecturer.Location = new System.Drawing.Point(759, 169);
            this.btnReportByLecturer.Name = "btnReportByLecturer";
            this.btnReportByLecturer.Size = new System.Drawing.Size(109, 51);
            this.btnReportByLecturer.TabIndex = 3;
            this.btnReportByLecturer.Text = "Xuất báo cáo theo giảng viên";
            this.btnReportByLecturer.UseVisualStyleBackColor = true;
            this.btnReportByLecturer.Click += new System.EventHandler(this.btnReportByLecturer_Click);
            // 
            // btnReportByCourse
            // 
            this.btnReportByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportByCourse.Location = new System.Drawing.Point(759, 89);
            this.btnReportByCourse.Name = "btnReportByCourse";
            this.btnReportByCourse.Size = new System.Drawing.Size(109, 54);
            this.btnReportByCourse.TabIndex = 2;
            this.btnReportByCourse.Text = "Xuất báo cáo theo môn";
            this.btnReportByCourse.UseVisualStyleBackColor = true;
            this.btnReportByCourse.Click += new System.EventHandler(this.btnReportByCourse_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(759, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 51);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(16, 17);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(713, 521);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(926, 241);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 39);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 575);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGvUsername;
        private System.Windows.Forms.TextBox txtGvEmail;
        private System.Windows.Forms.TextBox txtGvFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGvPassword;
        private System.Windows.Forms.Button btnDeleteGv;
        private System.Windows.Forms.Button btnEditGv;
        private System.Windows.Forms.Button btnAddGv;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button btnReportByLecturer;
        private System.Windows.Forms.Button btnReportByCourse;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnLogout;
    }
}
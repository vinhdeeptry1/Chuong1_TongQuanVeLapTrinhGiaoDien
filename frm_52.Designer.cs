namespace _2212493_VLCVinh_Chuong1_1
{
    partial class frm_52
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
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lbDanhSachChon = new System.Windows.Forms.ListBox();
            this.txtSVLop = new System.Windows.Forms.Label();
            this.txtSVThamGia = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSach.ForeColor = System.Drawing.Color.Red;
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 20;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Danh Nguyễn Tuấn Khanh",
            "Võ Lâm Chí Vĩnh",
            "Ngô Bá Tài",
            "Nguyễn Ái Mừng",
            "Đoàn Minh Đức",
            "Nguyễn Hiệp Hoàng",
            "Phan Ngọc Vỹ",
            "Nguyễn Tiến Đạt",
            "Phạm Thanh Bình",
            "Nguyễn Hồ Đức Huy"});
            this.lbDanhSach.Location = new System.Drawing.Point(84, 73);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSach.Size = new System.Drawing.Size(239, 204);
            this.lbDanhSach.TabIndex = 0;
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachChon.ForeColor = System.Drawing.Color.Green;
            this.lbDanhSachChon.FormattingEnabled = true;
            this.lbDanhSachChon.ItemHeight = 20;
            this.lbDanhSachChon.Location = new System.Drawing.Point(450, 73);
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.Size = new System.Drawing.Size(295, 204);
            this.lbDanhSachChon.TabIndex = 0;
            // 
            // txtSVLop
            // 
            this.txtSVLop.AutoSize = true;
            this.txtSVLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSVLop.Location = new System.Drawing.Point(81, 47);
            this.txtSVLop.Name = "txtSVLop";
            this.txtSVLop.Size = new System.Drawing.Size(188, 20);
            this.txtSVLop.TabIndex = 1;
            this.txtSVLop.Text = "Danh sách sinh viên lớp";
            this.txtSVLop.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSVThamGia
            // 
            this.txtSVThamGia.AutoSize = true;
            this.txtSVThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVThamGia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSVThamGia.Location = new System.Drawing.Point(447, 47);
            this.txtSVThamGia.Name = "txtSVThamGia";
            this.txtSVThamGia.Size = new System.Drawing.Size(298, 20);
            this.txtSVThamGia.TabIndex = 1;
            this.txtSVThamGia.Text = "Danh sách sinh viên tham gia đội bóng";
            this.txtSVThamGia.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChon
            // 
            this.btnChon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChon.FlatAppearance.BorderSize = 2;
            this.btnChon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChon.Location = new System.Drawing.Point(338, 98);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(95, 60);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(338, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 60);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frm_52
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtSVThamGia);
            this.Controls.Add(this.txtSVLop);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Name = "frm_52";
            this.Text = "frm_52";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox lbDanhSachChon;
        private System.Windows.Forms.Label txtSVLop;
        private System.Windows.Forms.Label txtSVThamGia;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
    }
}
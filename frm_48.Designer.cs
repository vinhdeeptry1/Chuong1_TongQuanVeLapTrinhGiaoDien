namespace _2212493_VLCVinh_Chuong1_1
{
    partial class frm_48
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
            this.cbChonNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.txtChonNgoaiNgu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbChonNgoaiNgu
            // 
            this.cbChonNgoaiNgu.FormattingEnabled = true;
            this.cbChonNgoaiNgu.Location = new System.Drawing.Point(265, 76);
            this.cbChonNgoaiNgu.Name = "cbChonNgoaiNgu";
            this.cbChonNgoaiNgu.Size = new System.Drawing.Size(317, 24);
            this.cbChonNgoaiNgu.TabIndex = 0;
            this.cbChonNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cbChonNgoaiNgu_SelectedIndexChanged);
            // 
            // txtChonNgoaiNgu
            // 
            this.txtChonNgoaiNgu.AutoSize = true;
            this.txtChonNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChonNgoaiNgu.Location = new System.Drawing.Point(97, 80);
            this.txtChonNgoaiNgu.Name = "txtChonNgoaiNgu";
            this.txtChonNgoaiNgu.Size = new System.Drawing.Size(151, 20);
            this.txtChonNgoaiNgu.TabIndex = 1;
            this.txtChonNgoaiNgu.Text = "Chọn ngoại ngữ: ";
            // 
            // frm_48
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 247);
            this.Controls.Add(this.txtChonNgoaiNgu);
            this.Controls.Add(this.cbChonNgoaiNgu);
            this.Name = "frm_48";
            this.Text = "frm48";
            this.Load += new System.EventHandler(this.frm_48_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChonNgoaiNgu;
        private System.Windows.Forms.Label txtChonNgoaiNgu;
    }
}
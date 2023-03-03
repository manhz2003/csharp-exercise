namespace BaiTap1
{
    partial class Form1
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
            this.lbNhapA = new System.Windows.Forms.Label();
            this.lbNhapB = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtAts = new System.Windows.Forms.TextBox();
            this.txtBts = new System.Windows.Forms.TextBox();
            this.txtBms = new System.Windows.Forms.TextBox();
            this.txtAms = new System.Windows.Forms.TextBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radnhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbNhapA
            // 
            this.lbNhapA.AutoSize = true;
            this.lbNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapA.ForeColor = System.Drawing.Color.White;
            this.lbNhapA.Location = new System.Drawing.Point(251, 51);
            this.lbNhapA.Name = "lbNhapA";
            this.lbNhapA.Size = new System.Drawing.Size(116, 16);
            this.lbNhapA.TabIndex = 0;
            this.lbNhapA.Text = "Nhập phân số a";
            // 
            // lbNhapB
            // 
            this.lbNhapB.AutoSize = true;
            this.lbNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapB.ForeColor = System.Drawing.Color.White;
            this.lbNhapB.Location = new System.Drawing.Point(251, 152);
            this.lbNhapB.Name = "lbNhapB";
            this.lbNhapB.Size = new System.Drawing.Size(116, 16);
            this.lbNhapB.TabIndex = 1;
            this.lbNhapB.Text = "Nhập phân số b";
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.OliveDrab;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnTinh.Location = new System.Drawing.Point(328, 298);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(62, 39);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Location = new System.Drawing.Point(403, 298);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 39);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtAts
            // 
            this.txtAts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAts.ForeColor = System.Drawing.Color.White;
            this.txtAts.Location = new System.Drawing.Point(254, 86);
            this.txtAts.Multiline = true;
            this.txtAts.Name = "txtAts";
            this.txtAts.Size = new System.Drawing.Size(133, 34);
            this.txtAts.TabIndex = 1;
            // 
            // txtBts
            // 
            this.txtBts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBts.ForeColor = System.Drawing.Color.White;
            this.txtBts.Location = new System.Drawing.Point(254, 185);
            this.txtBts.Multiline = true;
            this.txtBts.Name = "txtBts";
            this.txtBts.Size = new System.Drawing.Size(133, 34);
            this.txtBts.TabIndex = 2;
            // 
            // txtBms
            // 
            this.txtBms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBms.ForeColor = System.Drawing.Color.White;
            this.txtBms.Location = new System.Drawing.Point(407, 185);
            this.txtBms.Multiline = true;
            this.txtBms.Name = "txtBms";
            this.txtBms.Size = new System.Drawing.Size(133, 34);
            this.txtBms.TabIndex = 4;
            // 
            // txtAms
            // 
            this.txtAms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAms.ForeColor = System.Drawing.Color.White;
            this.txtAms.Location = new System.Drawing.Point(407, 86);
            this.txtAms.Multiline = true;
            this.txtAms.Name = "txtAms";
            this.txtAms.Size = new System.Drawing.Size(133, 34);
            this.txtAms.TabIndex = 3;
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCong.ForeColor = System.Drawing.Color.White;
            this.radCong.Location = new System.Drawing.Point(263, 304);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(41, 24);
            this.radCong.TabIndex = 8;
            this.radCong.TabStop = true;
            this.radCong.Text = "+";
            this.radCong.UseVisualStyleBackColor = true;
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTru.ForeColor = System.Drawing.Color.White;
            this.radTru.Location = new System.Drawing.Point(376, 247);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(37, 24);
            this.radTru.TabIndex = 5;
            this.radTru.TabStop = true;
            this.radTru.Text = "-";
            this.radTru.UseVisualStyleBackColor = true;
            // 
            // radnhan
            // 
            this.radnhan.AutoSize = true;
            this.radnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnhan.ForeColor = System.Drawing.Color.White;
            this.radnhan.Location = new System.Drawing.Point(499, 304);
            this.radnhan.Name = "radnhan";
            this.radnhan.Size = new System.Drawing.Size(41, 24);
            this.radnhan.TabIndex = 6;
            this.radnhan.TabStop = true;
            this.radnhan.Text = "×";
            this.radnhan.UseVisualStyleBackColor = true;
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChia.ForeColor = System.Drawing.Color.White;
            this.radChia.Location = new System.Drawing.Point(376, 373);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(41, 24);
            this.radChia.TabIndex = 7;
            this.radChia.TabStop = true;
            this.radChia.Text = "÷";
            this.radChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radChia);
            this.Controls.Add(this.radnhan);
            this.Controls.Add(this.radTru);
            this.Controls.Add(this.radCong);
            this.Controls.Add(this.txtAms);
            this.Controls.Add(this.txtBms);
            this.Controls.Add(this.txtBts);
            this.Controls.Add(this.txtAts);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lbNhapB);
            this.Controls.Add(this.lbNhapA);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính phân số";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapA;
        private System.Windows.Forms.Label lbNhapB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtAts;
        private System.Windows.Forms.TextBox txtBts;
        private System.Windows.Forms.TextBox txtBms;
        private System.Windows.Forms.TextBox txtAms;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radnhan;
        private System.Windows.Forms.RadioButton radChia;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1 : Form
    {        
        
        public Form1()
        {
            InitializeComponent();
        }
                     
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtAts.Text == "" || txtAms.Text == "" || txtBts.Text == "" || txtBms.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập phân số");
                return;
            }
            int tuA = int.Parse(txtAts.Text);
            int mauA = int.Parse(txtAms.Text);
            int tuB = int.Parse(txtBts.Text);
            int mauB = int.Parse(txtBms.Text);
            PhanSo psA = new PhanSo(tuA, mauA);
            PhanSo psB = new PhanSo(tuB, mauB);
            PhanSo psKQ = null;

            if (radCong.Checked)
            {
                psKQ = psA + psB;
                psKQ.RutGon();
            }
            else if(radTru.Checked)
            {
                psKQ = psA - psB;
            }
            else if(radnhan.Checked)
            {
                psKQ = psA * psB;
                psKQ.RutGon();
            }    
            else if(radChia.Checked)
            {
                psKQ = psA / psB;
            }    

            if (psKQ != null)
            {
                Form2 f2 = new Form2();
                f2.KetQua = psKQ.ToString();
                f2.lbKq_Click(null, null);
                f2.ShowDialog();

            }

            if (!radCong.Checked && !radTru.Checked && !radnhan.Checked && !radChia.Checked)
            {
                MessageBox.Show("Bạn chưa chọn phép tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtAts.Text = string.Empty;
            txtAms.Text = string.Empty;
            txtBts.Text = string.Empty;
            txtBms.Text = string.Empty;

            foreach (Control ctrl in this.Controls)
            {
                // Kiểm tra xem control đó có phải là radiobutton không
                if (ctrl is RadioButton)
                {
                    // Nếu là radiobutton thì bỏ chọn nó
                    ((RadioButton)ctrl).Checked = false;
                }
            }
        }

    }
}

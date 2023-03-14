using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TongHaiSoBUS;

namespace TongHaiSoGUI
{
    public partial class Form1 : Form
    {
        private CalcBUS bus = new CalcBUS();
        private DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("a", typeof(int));
            table.Columns.Add("b", typeof(int));
            table.Columns.Add("ketqua", typeof(int));

            // Gán DataTable vào DataSource của DataGridView
            dataGridView1.DataSource = table;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txtA.Text);
                int s2 = int.Parse(txtB.Text);

                int sum = bus.GetSum(s1, s2);

                txtKetQua.Text = sum.ToString();
                // Thêm dữ liệu mới vào DataTable và cập nhật lên DataGridView
                DataRow row = table.NewRow();
                row["a"] = s1;
                row["b"] = s2;
                row["ketqua"] = sum;
                table.Rows.Add(row);
            }
            catch (Exception ex)
            {
                // Xử lý exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtKetQua.Text = string.Empty;
            table.Clear();
        }
    }
}

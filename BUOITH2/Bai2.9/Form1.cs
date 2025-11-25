namespace Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKetQua.Text = $"Chu Vi = " + 2 * (a + b);
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKetQua.Text = $"Dien tich = " + (a * b);
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double chuvi = Math.Sqrt(a * a + b * b);
            txtKetQua.Text = $"Đường chéo =" + Math.Round(chuvi, 2);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

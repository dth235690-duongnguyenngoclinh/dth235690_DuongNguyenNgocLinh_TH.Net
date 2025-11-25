namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKetQua.Text = ("Tổng là :" + (a + b));
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKetQua.Text = ("Hiệu là: " + (a - b));
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKetQua.Text = ("Tích là: " + (a * b));

        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            if (b == 0)
                txtKetQua.Text = ("Không thể chia 0");
            else
                txtKetQua.Text = ("Thương là: " + (a / b));
        }
    }
}

namespace Bai2._6
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
            MessageBox.Show("Tổng là: " + (a + b));
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            MessageBox.Show("Hiệu là: " + (a - b));
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            MessageBox.Show("Tích là: " + (a * b));
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            if (b == 0)
                MessageBox.Show("Không thể chia cho 0!");
            else
                MessageBox.Show("Thương là: " + (a / b));
        }
    }
}

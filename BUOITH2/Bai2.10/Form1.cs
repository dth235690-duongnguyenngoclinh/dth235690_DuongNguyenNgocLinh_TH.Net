namespace Bai2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            MessageBox.Show($"Dien tich = " + (a * b));
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            MessageBox.Show($"Chu vi = " + (2 * (a + b)));
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double duongcheo = Math.Sqrt(a * a + b * b);
            MessageBox.Show($"Duong cheo = " + Math.Round(duongcheo, 2));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

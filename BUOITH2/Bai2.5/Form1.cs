namespace Bai2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int tong = a + b;
            MessageBox.Show("Tổng là: " + tong);
        }
    }
}

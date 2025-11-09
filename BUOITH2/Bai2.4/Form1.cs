namespace Bai2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string hoten = txtNhapHoTen.Text;
            MessageBox.Show("Chào bạn " + hoten + " đến với môn học LẬP TRÌNH .NET!");
        }
    }
}

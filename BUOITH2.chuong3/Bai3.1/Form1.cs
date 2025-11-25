namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double f;

            if (x >= 2)
                f = -8 * Math.Pow(x, 3) - 12 * x - 1;
            else if (x > 1 && x < 2)
                f = Math.Pow(x, 2) - 6 * x - 19;
            else
                f = 7 * x;

            txtF.Text = $"f(x) = {f}";
        }
    }
}

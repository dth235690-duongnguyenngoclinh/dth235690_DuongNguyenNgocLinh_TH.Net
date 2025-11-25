namespace Bai4._1._2._3._4._5._6._7
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

        private void btnTinhB1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += i;
            }

            txtS.Text = "S = 1 + 2 + ... + " + n + " = " + S;
        }

        private void btnTinhB2_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtN.Text);
            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += i * i;
            }

            txtS.Text = "S = 1² + 2² + ... + " + n + "² = " + S;
        }

        private void btnTinhB3_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtN.Text);
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += 1.0 / i;
            }

            txtS.Text = "S = 1 + 1/2 + ... + 1/" + n + " = " + Math.Round(S, 4);
        }

        private void btnTinhB4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int S = 0;

            for (int i = 1; i <= n + 1; i++)
            {
                S += 2 * i - 1;
            }

            txtS.Text = "S = 1 + 3 + 5 + ... + (2n+1) = " + S;
        }

        private void btnTinhB5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += 2 * i;
            }

            txtS.Text = "S = 2 + 4 + ... + 2n = " + S;
        }

        private void btnTinhB6_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += 1.0 / (2 * i - 1);
            }

            txtS.Text = "S = 1 + 1/3 + 1/5 + ... + 1/(2n-1) = " + Math.Round(S, 4);
        }

        private void btnTinhB7_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            long S = 1;

            for (int i = 1; i <= n; i++)
            {
                S *= i;
            }

            txtS.Text = n + "! = " + S;
        }
    }
}

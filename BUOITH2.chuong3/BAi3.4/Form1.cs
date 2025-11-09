namespace BAi3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                if (!double.TryParse(txtA.Text, out a) ||
               !double.TryParse(txtB.Text, out b) ||
               !double.TryParse(txtC.Text, out c))
                {
                    txtKetQua.Text = "⚠️ Vui lòng nhập số hợp lệ cho a, b, c!";
                    return;
                }

                string kq = "";

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            kq = "PT có vô số nghiệm.";
                        else
                            kq = "PT vô nghiệm.";
                    }
                    else
                    {
                        double x = -c / b;
                        kq = $"PT bậc nhất có nghiệm x = {x}";
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                        kq = "Phương trình vô nghiệm.";
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        kq = $"PT có nghiệm kép: x = {x}";
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        kq = $"PT có 2 nghiệm:\r\n x1 = {x1}, x2 = {x2}";
                    }
                }

                txtKetQua.Text = kq;
            }

            catch
            {
                txtKetQua.Text = "⚠️ Lỗi nhập liệu! Vui lòng nhập số hợp lệ.";
            }
        }
    }
}

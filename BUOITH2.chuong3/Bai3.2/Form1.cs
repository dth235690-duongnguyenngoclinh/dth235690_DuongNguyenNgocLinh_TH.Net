namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(txtThang.Text);
            string mua;

            if (thang >= 1 && thang <= 3)
                mua = "🌸 Mùa xuân";
            else if (thang >= 4 && thang <= 6)
                mua = "☀️ Mùa hạ";
            else if (thang >= 7 && thang <= 9)
                mua = "🍂 Mùa thu";
            else if (thang >= 10 && thang <= 12)
                mua = "❄ Mùa đông";
            else
                mua = "⚠️ Tháng không hợp lệ!";

            MessageBox.Show($"Tháng {thang} thuộc {mua}", "Kết quả");

        }
    }
}

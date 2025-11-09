namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txtNgay.Text);
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);

            bool hopLe = true;

            if (thang < 1 || thang > 12 || ngay < 1)
                hopLe = false;
            else
            {
                int soNgay = 31;
                switch (thang)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        soNgay = 30;
                        break;
                    case 2:
                        soNgay = (DateTime.IsLeapYear(nam)) ? 29 : 28;
                        break;
                }
                if (ngay > soNgay)
                    hopLe = false;
            }

            if (hopLe)
                MessageBox.Show("✅ Ngày tháng hợp lệ!", "Kết quả");
            else
                MessageBox.Show("❌ Ngày tháng không hợp lệ!", "Kết quả");
        }
    }
}

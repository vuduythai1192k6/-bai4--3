namespace bai4_3
{
    public partial class Form1 : Form
    {
        double soThuNhat = 0;
        string phepToan = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void PhepToan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = btn.Text;
            txtDisplay.Clear();
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            double soThuHai = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            if (phepToan == "+")
                ketQua = soThuNhat + soThuHai;
            else if (phepToan == "-")
                ketQua = soThuNhat - soThuHai;
            else if (phepToan == "x")
                ketQua = soThuNhat * soThuHai;
            else if (phepToan == ":")
                ketQua = soThuNhat / soThuHai;

            txtDisplay.Text = ketQua.ToString();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            soThuNhat = 0;
            phepToan = "";
        }
    }
}

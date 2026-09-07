namespace Câu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtPassWord.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
            txtPassWord.Clear();
            txtPassWord.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHienThi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl;

            dl = MessageBox.Show(
                "Có chắc bạn muốn đóng ứng dụng?",
                "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

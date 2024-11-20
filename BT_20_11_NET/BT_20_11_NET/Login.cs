using System.Data.SqlClient;

namespace BT_20_11_NET
{
    public partial class Login : Form
    {
        private DAO DAO = new DAO();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassWord.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Sử dụng DatabaseHelper để kiểm tra đăng nhập
                string query = "SELECT COUNT(*) FROM NguoiDung WHERE tendangnhap = @username AND matkhau = @password";
                int count = (int)DAO.ExecuteQuery(query,
                    new System.Data.SqlClient.SqlParameter("@username", username),
                    new System.Data.SqlClient.SqlParameter("@password", password)).Rows[0][0];

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Chuyển tới giao diện chính
                    TrangChu main = new TrangChu();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

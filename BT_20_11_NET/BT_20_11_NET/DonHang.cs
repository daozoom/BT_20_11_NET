using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_20_11_NET
{
    public partial class DonHang : Form
    {
        private DAO dao_DB = new DAO();

        public DonHang()
        {
            InitializeComponent();
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            string query = "SELECT * FROM DonHang";
            dtgvDonHang.DataSource = dao_DB.ExecuteQuery(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DonHang WHERE id LIKE @keyword";
            dtgvDonHang.DataSource = dao_DB.ExecuteQuery(query,
                new SqlParameter("@keyword", "%" + tbSearch.Text.Trim() + "%"));
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường thông tin có trống hay không
            if (string.IsNullOrEmpty(tbIDKH.Text) || string.IsNullOrEmpty(tbIDSP.Text) || string.IsNullOrEmpty(tbSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES (@khachhangid, @sanphamid, @soluong, @ngaymua)";

            dao_DB.ExecuteNonQuery(query,
                new SqlParameter("@khachhangid", tbIDKH.Text),
                new SqlParameter("@sanphamid", tbIDSP.Text),
                new SqlParameter("@soluong", tbSL.Text),
                new SqlParameter("@ngaymua", dtpDate.Value));
            LoadDonHang();
            MessageBox.Show("Thêm đơn hàng thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Nếu trường tbIDDH (ID đơn hàng) không được chọn, không cho phép cập nhật
            if (string.IsNullOrEmpty(tbIDDH.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE DonHang SET khachhangid=@khachhangid, sanphamid=@sanphamid, soluong=@soluong, ngaymua=@ngaymua WHERE id=@id";

            dao_DB.ExecuteNonQuery(query,
                new SqlParameter("@id", tbIDDH.Text),
                new SqlParameter("@khachhangid", tbIDKH.Text),
                new SqlParameter("@sanphamid", tbIDSP.Text),
                new SqlParameter("@soluong", tbSL.Text),
                new SqlParameter("@ngaymua", dtpDate.Value));

            LoadDonHang();

            MessageBox.Show("Cập nhật đơn hàng thành công!");

            // Xóa hết dữ liệu trong các ô TextBox
            tbIDDH.Clear();           // Xóa TextBox ID
            tbIDKH.Clear();    // Xóa TextBox ID khách hàng
            tbIDSP.Clear();      // Xóa TextBox ID sản phẩm
            tbSL.Clear();        // Xóa TextBox số lượng
            dtpDate.Value = DateTime.Now;  // Đặt lại giá trị DateTimePicker về ngày hiện tại
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM DonHang WHERE id=@id";
            dao_DB.ExecuteNonQuery(query, new SqlParameter("@id", tbIDDH.Text));
            LoadDonHang();
            MessageBox.Show("Xóa đơn hàng thành công!");

            // Xóa hết dữ liệu trong các ô TextBox
            tbIDDH.Clear();           // Xóa TextBox ID
            tbIDKH.Clear();    // Xóa TextBox ID khách hàng
            tbIDSP.Clear();      // Xóa TextBox ID sản phẩm
            tbSL.Clear();        // Xóa TextBox số lượng
            dtpDate.Value = DateTime.Now;  // Đặt lại giá trị DateTimePicker về ngày hiện tại
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DonHang";
            dtgvDonHang.DataSource = dao_DB.ExecuteQuery(query);
        }

        private void dtgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                DataGridViewRow row = dtgvDonHang.Rows[e.RowIndex];

                // Điền thông tin vào các TextBox
                tbIDDH.Text = row.Cells["id"].Value.ToString();            // ID đơn hàng (thông tin tham khảo)
                tbIDKH.Text = row.Cells["khachhangid"].Value.ToString();
                tbIDSP.Text = row.Cells["sanphamid"].Value.ToString();
                tbSL.Text = row.Cells["soluong"].Value.ToString();
                dtpDate.Value = DateTime.Parse(row.Cells["ngaymua"].Value.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa hết dữ liệu trong các ô TextBox
            tbIDDH.Clear();           // Xóa TextBox ID
            tbIDKH.Clear();    // Xóa TextBox ID khách hàng
            tbIDSP.Clear();      // Xóa TextBox ID sản phẩm
            tbSL.Clear();        // Xóa TextBox số lượng
            dtpDate.Value = DateTime.Now;  // Đặt lại giá trị DateTimePicker về ngày hiện tại
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_20_11_NET
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void mnstrSP_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.ShowDialog();
        }

        private void mnstrKH_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
        }

        private void mnstrDH_Click(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang();
            donHang.ShowDialog();
        }
    }
}

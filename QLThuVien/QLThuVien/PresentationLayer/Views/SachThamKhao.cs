using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class SachThamKhao : SachView
    {
        public SachThamKhao() : base(new SachThamKhao(), new SachThamKhaoController())
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            dataGridView1.DataSource = controller.LoadData();
        }

        protected override void ClearAll()
        {
            txtMaSach.Clear();
            txtNhaXuatBan.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThue.Clear();
        }

        private void SachThamKhao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            controller.DeleteSach(maSach);
            LoadData();
            ClearAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            DateTime ngayNhap = dateNgayNhap.Value;
            string nhaXuatBan = txtNhaXuatBan.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            int donGia = Convert.ToInt32(txtDonGia.Text);
            int thue = Convert.ToInt32(txtThue.Text);
            controller.UpdateSach(new SachThamKhao { MaSach = maSach, NgayNhap = ngayNhap, NhaXuatBan = nhaXuatBan, SoLuong = soLuong, DonGia = donGia, Thue = thue });
            LoadData();
            ClearAll();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dateNgayNhap.Value;
            string query = "SELECT * from SachThamKhao WHERE 1=1";
            if (txtMaSach.Text != "")
                query += " AND MaSach LIKE N'%" + txtMaSach.Text + "%'";
            if (txtNhaXuatBan.Text != "")
                query += " AND NhaXuatBan LIKE N'%" + txtNhaXuatBan.Text + "%'";
            if (txtDonGia.Text != "")
                query += " AND DonGia LIKE N'%" + txtDonGia.Text + "%'";
            if (txtSoLuong.Text != "")
                query += " AND SoLuong LIKE N'%" + txtSoLuong.Text + "%'";
            if (txtThue.Text != "")
                query += " AND Thue LIKE N'%" + txtThue.Text + "%'";
            if (checkbTimKiemNgay.Checked)
                query += " AND NgayNhap LIKE '" + ngayNhap.ToString("yyyy-MM-dd") + "%'";

            dataGridView1.DataSource = controller.SearchSach(query);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            controller.ThanhToanSach(maSach, soLuong);
            LoadData();
            ClearAll();
        }

        private void btnBaoGia_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            int totalPrice = controller.BaoGiaSach(maSach, soLuong);
            txtBaoGia.Text = totalPrice.ToString() + " VND";
        }

        private void SachThamKhao_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
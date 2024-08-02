// File: BusinessLogicLayer/Strategies/SachGiaoKhoaStrategy.cs
using BusinessLogicLayer.Models;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer.Strategies
{
    public class SachGiaoKhoaStrategy : ISachStrategy
    {
        private KetNoiCSDL ketNoi = KetNoiCSDL.Instance;

        public void AddSach(Sach sach)
        {
            SachGiaoKhoa sgk = sach as SachGiaoKhoa;
            string ngayNhapString = sgk.NgayNhap.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO SachGiaoKhoa (MaSach, NgayNhap, NhaXuatBan, DonGia, SoLuong, TinhTrang) VALUES ('{sgk.MaSach}', '{ngayNhapString}', N'{sgk.NhaXuatBan}', {sgk.DonGia}, {sgk.SoLuong}, N'{sgk.TinhTrang}')";
            ketNoi.ExecuteNonQuery(query);
        }

        public void UpdateSach(Sach sach)
        {
            SachGiaoKhoa sgk = sach as SachGiaoKhoa;
            string ngayNhapString = sgk.NgayNhap.ToString("yyyy-MM-dd");
            string query = $"UPDATE SachGiaoKhoa SET NgayNhap = '{ngayNhapString}', NhaXuatBan = N'{sgk.NhaXuatBan}', DonGia = {sgk.DonGia}, SoLuong = {sgk.SoLuong}, TinhTrang = N'{sgk.TinhTrang}' WHERE MaSach = '{sgk.MaSach}'";
            ketNoi.ExecuteNonQuery(query);
        }

        public void DeleteSach(string maSach)
        {
            string query = $"DELETE FROM SachGiaoKhoa WHERE MaSach = '{maSach}'";
            ketNoi.ExecuteNonQuery(query);
        }

        public DataTable SearchSach(string query)
        {
            return ketNoi.Execute(query);
        }
    }
}
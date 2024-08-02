// File: BusinessLogicLayer/Strategies/SachThamKhaoStrategy.cs
using BusinessLogicLayer.Models;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer.Strategies
{
    public class SachThamKhaoStrategy : ISachStrategy
    {
        private KetNoiCSDL ketNoi = KetNoiCSDL.Instance;

        public void AddSach(Sach sach)
        {
            SachThamKhao stk = sach as SachThamKhao;
            string ngayNhapString = stk.NgayNhap.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO SachThamKhao (MaSach, NgayNhap, NhaXuatBan, DonGia, SoLuong, Thue) VALUES ('{stk.MaSach}', '{ngayNhapString}', N'{stk.NhaXuatBan}', {stk.DonGia}, {stk.SoLuong}, {stk.Thue})";
            ketNoi.ExecuteNonQuery(query);
        }

        public void UpdateSach(Sach sach)
        {
            SachThamKhao stk = sach as SachThamKhao;
            string ngayNhapString = stk.NgayNhap.ToString("yyyy-MM-dd");
            string query = $"UPDATE SachThamKhao SET NgayNhap = '{ngayNhapString}', NhaXuatBan = N'{stk.NhaXuatBan}', DonGia = {stk.DonGia}, SoLuong = {stk.SoLuong}, Thue = {stk.Thue} WHERE MaSach = '{stk.MaSach}'";
            ketNoi.ExecuteNonQuery(query);
        }

        public void DeleteSach(string maSach)
        {
            string query = $"DELETE FROM SachThamKhao WHERE MaSach = '{maSach}'";
            ketNoi.ExecuteNonQuery(query);
        }

        public DataTable SearchSach(string query)
        {
            return ketNoi.Execute(query);
        }
    }
}
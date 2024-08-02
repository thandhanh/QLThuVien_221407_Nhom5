// File: Models/SachThamKhao.cs
using System;
using System.Data;

namespace BusinessLogicLayer.Models
{
    public class SachThamKhao : Sach
    {
        public int Thue { get; set; }

        public override void Add()
        {
            string ngayNhapString = NgayNhap.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO SachThamKhao (MaSach, NgayNhap, NhaXuatBan, DonGia, SoLuong, Thue) VALUES ('{MaSach}', '{ngayNhapString}', N'{NhaXuatBan}', {DonGia}, {SoLuong}, {Thue})";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            ketNoi.ExecuteNonQuery(query);
            ChangeState();
        }

        public override DataTable LoadData()
        {
            string query = "SELECT * FROM SachThamKhao";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            DataTable result = ketNoi.Execute(query);
            ChangeState();
            return result;
        }

        private void ChangeState()
        {
            Notify();
        }
    }
}
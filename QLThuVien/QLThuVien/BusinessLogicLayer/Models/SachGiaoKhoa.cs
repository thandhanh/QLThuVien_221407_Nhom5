// File: Models/SachGiaoKhoa.cs
using System;
using System.Data;

namespace BusinessLogicLayer.Models
{
    public class SachGiaoKhoa : Sach
    {
        public string TinhTrang { get; set; }

        public override void Add()
        {
            string ngayNhapString = NgayNhap.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO SachGiaoKhoa (MaSach, NgayNhap, NhaXuatBan, DonGia, SoLuong, TinhTrang) VALUES ('{MaSach}', '{ngayNhapString}', N'{NhaXuatBan}', {DonGia}, {SoLuong}, N'{TinhTrang}')";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            ketNoi.ExecuteNonQuery(query);
            ChangeState();
        }

        public override DataTable LoadData()
        {
            string query = "SELECT * FROM SachGiaoKhoa";
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
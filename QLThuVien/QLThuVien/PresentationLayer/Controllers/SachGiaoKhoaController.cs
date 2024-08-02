// File: PresentationLayer/Controllers/SachGiaoKhoaController.cs
namespace PresentationLayer.Controllers
{
    using BusinessLogicLayer.Models;
    using BusinessLogicLayer.Strategies;
    using DataAccessLayer;
    using System.Data;

    public class SachGiaoKhoaController : SachController
    {
        private ISachStrategy sachStrategy;

        public SachGiaoKhoaController()
        {
            SetSachFactory(new SachGiaoKhoaFactory());
            sachStrategy = new SachGiaoKhoaStrategy();
        }
        public override int BaoGiaSach(string maSach, int soLuong)
        {
            DataTable data = sachStrategy.SearchSach($"SELECT * FROM SachGiaoKhoa WHERE MaSach = '{maSach}'");
            if (data.Rows.Count > 0)
            {
                int donGia = Convert.ToInt32(data.Rows[0]["DonGia"]);
                string tinhTrang = data.Rows[0]["TinhTrang"].ToString();
                int totalPrice = tinhTrang == "mới" ? soLuong * donGia : soLuong * donGia * 50 / 100;
                return totalPrice;
            }
            return 0;
        }

        public override DataTable LoadData()
        {
            string query = "SELECT * FROM SachGiaoKhoa";
            return ketNoi.Execute(query);
        }

        public override void AddSach(Sach sach, int discount = 0)
        {
            if (discount > 0)
            {
                sach = new SachWithDiscount(sach, discount);
            }
            sachStrategy.AddSach(sach);
        }

        public override void UpdateSach(Sach sach)
        {
            sachStrategy.UpdateSach(sach);
        }

        public override void DeleteSach(string maSach)
        {
            sachStrategy.DeleteSach(maSach);
        }

        public override DataTable SearchSach(string query)
        {
            return sachStrategy.SearchSach(query);
        }
    }
}
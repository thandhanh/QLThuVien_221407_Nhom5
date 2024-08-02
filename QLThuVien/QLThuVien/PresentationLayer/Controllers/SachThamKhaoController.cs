// File: PresentationLayer/Controllers/SachThamKhaoController.cs
namespace PresentationLayer.Controllers
{
    using BusinessLogicLayer.Models;
    using BusinessLogicLayer.Strategies;
    using DataAccessLayer;
    using System.Data;

    public class SachThamKhaoController : SachController
    {
        private ISachStrategy sachStrategy;

        public SachThamKhaoController()
        {
            SetSachFactory(new SachThamKhaoFactory());
            sachStrategy = new SachThamKhaoStrategy();
        }

        public override int BaoGiaSach(string maSach, int soLuong)
        {
            DataTable data = sachStrategy.SearchSach($"SELECT * FROM SachThamKhao WHERE MaSach = '{maSach}'");
            if (data.Rows.Count > 0)
            {
                int donGia = Convert.ToInt32(data.Rows[0]["DonGia"]);
                int thue = Convert.ToInt32(data.Rows[0]["Thue"]);
                int totalPrice = soLuong * donGia + thue;
                return totalPrice;
            }
            return 0;
        }

        public override DataTable LoadData()
        {
            string query = "SELECT * FROM SachThamKhao";
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
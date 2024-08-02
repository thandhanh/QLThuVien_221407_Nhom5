// File: BusinessLogicLayer/Strategies/ISachStrategy.cs
using BusinessLogicLayer.Models;
using System.Data;

namespace BusinessLogicLayer.Strategies
{
    public interface ISachStrategy
    {
        void AddSach(Sach sach);
        void UpdateSach(Sach sach);
        void DeleteSach(string maSach);
        DataTable SearchSach(string query);
    }
}
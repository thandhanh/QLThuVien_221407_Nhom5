// File: BusinessLogicLayer/Decorators/SachWithDiscount.cs
using System.Data;

namespace BusinessLogicLayer.Models
{
    public class SachWithDiscount : SachDecorator
    {
        private int discount;

        public SachWithDiscount(Sach sach, int discount) : base(sach)
        {
            this.discount = discount;
        }

        public override void Add()
        {
            sach.DonGia -= sach.DonGia * discount / 100;
            base.Add();
        }
    }
}
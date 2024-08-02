// File: BusinessLogicLayer/Decorators/SachDecorator.cs
using System.Data;

namespace BusinessLogicLayer.Models
{
    public abstract class SachDecorator : Sach
    {
        protected Sach sach;

        public SachDecorator(Sach sach)
        {
            this.sach = sach;
        }

        public override void Add()
        {
            sach.Add();
        }

        public override DataTable LoadData()
        {
            return sach.LoadData();
        }
    }
}
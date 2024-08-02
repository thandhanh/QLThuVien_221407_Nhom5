// File: PresentationLayer/Controllers/SachController.cs
namespace PresentationLayer.Controllers
{
    using BusinessLogicLayer.Commands;
    using BusinessLogicLayer.Models;
    using DataAccessLayer;
    using System.Data;

    public abstract class SachController
    {
        protected KetNoiCSDL ketNoi;
        private CommandInvoker _invoker;
        protected SachFactory sachFactory;

        public SachController()
        {
            ketNoi = KetNoiCSDL.Instance;
            _invoker = new CommandInvoker();
        }
        public abstract int BaoGiaSach(string maSach, int soLuong);
        public void SetCommand(ICommand command)
        {
            _invoker.SetCommand(command);
        }

        public void ExecuteCommand()
        {
            _invoker.ExecuteCommand();
        }

        public void SetSachFactory(SachFactory factory)
        {
            sachFactory = factory;
        }

        public void AddSach(Sach sach, int discount = 0)
        {
            if (discount > 0)
            {
                sach = new SachWithDiscount(sach, discount);
            }
            sach.Add();
        }

        public abstract DataTable LoadData();
        public abstract void DeleteSach(string maSach);
        public abstract void UpdateSach(Sach sach);
        public abstract DataTable SearchSach(string query);
    }
}
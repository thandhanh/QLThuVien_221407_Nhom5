// File: Commands/UpdateSachCommand.cs
using PresentationLayer.Controllers;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Commands
{
    public class UpdateSachCommand : Command
    {
        private Sach sach;

        public UpdateSachCommand(SachController sachController, Sach sach) : base(sachController)
        {
            this.sach = sach;
        }

        public override void Execute()
        {
            sachController.UpdateSach(sach);
        }
    }
}
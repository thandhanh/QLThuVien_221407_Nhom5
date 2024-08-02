// File: Commands/AddSachCommand.cs
using PresentationLayer.Controllers;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Commands
{
    public class AddSachCommand : Command
    {
        private Sach sach;

        public AddSachCommand(SachController sachController, Sach sach) : base(sachController)
        {
            this.sach = sach;
        }

        public override void Execute()
        {
            sachController.AddSach(sach);
        }
    }
}
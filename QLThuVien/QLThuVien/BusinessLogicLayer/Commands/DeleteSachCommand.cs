// File: Commands/DeleteSachCommand.cs
using PresentationLayer.Controllers;

namespace BusinessLogicLayer.Commands
{
    public class DeleteSachCommand : Command
    {
        private string maSach;

        public DeleteSachCommand(SachController sachController, string maSach) : base(sachController)
        {
            this.maSach = maSach;
        }

        public override void Execute()
        {
            sachController.DeleteSach(maSach);
        }
    }
}
// File: Commands/Command.cs
using PresentationLayer.Controllers;

namespace BusinessLogicLayer.Commands
{
    public abstract class Command
    {
        protected SachController sachController;

        public Command(SachController sachController)
        {
            this.sachController = sachController;
        }

        public abstract void Execute();
    }
}
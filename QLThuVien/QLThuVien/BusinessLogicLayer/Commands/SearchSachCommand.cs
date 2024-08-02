// File: Commands/SearchSachCommand.cs
using PresentationLayer.Controllers;
using System.Data;

namespace BusinessLogicLayer.Commands
{
    public class SearchSachCommand : Command
    {
        private string query;
        private DataTable result;

        public SearchSachCommand(SachController sachController, string query) : base(sachController)
        {
            this.query = query;
        }

        public override void Execute()
        {
            result = sachController.SearchSach(query);
        }

        public DataTable GetResult()
        {
            return result;
        }
    }
}
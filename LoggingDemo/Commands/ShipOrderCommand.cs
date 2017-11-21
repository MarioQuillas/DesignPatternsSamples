using System;

namespace LoggingDemo.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string CommandName => "ShipOrder";

        public string Description => CommandName;

        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
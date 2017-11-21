using System;

namespace LoggingDemo.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string CommandName => "CreateOrder";

        public string Description => CommandName;

        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
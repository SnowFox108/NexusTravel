using System;

namespace NexusTravel.Infrastructure.Command
{
    public class CommandHandlerNotFoundException : Exception
    {
        public CommandHandlerNotFoundException(Type type) : base(
            String.Format($"Command handler not found for command type: {type}"))
        {

        }
    }
}

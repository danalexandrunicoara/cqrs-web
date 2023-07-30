public class CommandDispatcher<T> : ICommandDispatcher<T> where T : ICommand
{
    private readonly ICommandHandler<T> _commandHandler;
    public CommandDispatcher(ICommandHandler<T> commandHandler) => _commandHandler = commandHandler;
    public bool Send(T command)
    {
        return _commandHandler.Handle(command);
    }
}
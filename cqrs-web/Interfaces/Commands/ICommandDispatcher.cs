public interface ICommandDispatcher<T> where T : ICommand
{
    bool Send(T command);
}
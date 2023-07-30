public interface ICommandHandler<T> where T : ICommand
{
    bool Handle(T command);
}
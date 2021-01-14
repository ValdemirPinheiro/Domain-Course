using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handlres
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}

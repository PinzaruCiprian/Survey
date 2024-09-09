using MediatR;

namespace eSurvey.Application.Interfaces
{
     public interface ICommand : IRequest { }
     public interface ICommand<out T> : IRequest<T> { }
}

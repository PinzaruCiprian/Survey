using MediatR;

namespace eSurvey.Application.Interfaces
{
     public interface IQuery : IRequest { }
     public interface IQuery<out T> : IRequest<T> { }
}

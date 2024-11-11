using MediatR;

namespace BuildingBlocks.CQRS;

/// <summary>
/// This is a generic interface for defining queries, with TResponse as the type of data the query will return
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : notnull
{
}
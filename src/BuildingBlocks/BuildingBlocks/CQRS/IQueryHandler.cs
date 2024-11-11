using MediatR;

namespace BuildingBlocks.CQRS;

/// <summary>
/// This interface defines a handler for queries (read-only operations) that return a response of type TResponse. By implementing this interface, you create a handler that knows how to process a specific query and return the expected data.
/// </summary>
/// <typeparam name="TQuery">Ensures that TQuery is a query that expects a response of type TResponse.</typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : notnull
{
}
using MediatR;

namespace BuildingBlocks.CQRS;

/*
    Used to create command abstractions within a CQRS pattern
 */

/// <summary>
/// Essentially, this non-generic ICommand interface is for commands that don’t need to return a result.
/// Unit is a type from MediatR (similar to void in other contexts), representing a "no response" scenario.
/// </summary>
public interface ICommand : ICommand<Unit>
{
}

/// <summary>
/// Inherits from MediatR’s IRequest<TResponse>
/// </summary>
/// <typeparam name="TResponse">In MediatR, IRequest<TResponse> represents a request that will be processed by a handler, which returns a response of type TResponse.</typeparam>
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}

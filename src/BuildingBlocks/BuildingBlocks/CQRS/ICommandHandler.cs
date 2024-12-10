using MediatR;

namespace BuildingBlocks.CQRS;

/*
    Define abstractions for handling commands within the CQRS pattern
 */

/// <summary>
/// This interface is for handling commands that do not return any result
/// </summary>
/// <typeparam name="TCommand"></typeparam>
public interface ICommandHandler<in TCommand>
    : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
{ 
}

/// <summary>
///  This is the core command handler interface, designed to handle commands that expect a response of type TResponse.
/// </summary>
/// <typeparam name="TCommand">This constraint enforces that TCommand must be a command with a response type of TResponse</typeparam>
/// <typeparam name="TResponse">This ensures that the response type cannot be null, reinforcing that commands will return a meaningful result.</typeparam>
public interface ICommandHandler<in TCommand, TResponse> : 
    IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
}

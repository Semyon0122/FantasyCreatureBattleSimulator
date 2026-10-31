using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

public abstract record GetAttackedEntityResult
{
    public sealed record Success(IEntity Entity) : GetAttackedEntityResult;

    public sealed record Failure(string Message) : GetAttackedEntityResult;
}
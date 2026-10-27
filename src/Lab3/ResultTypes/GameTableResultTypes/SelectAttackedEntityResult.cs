using Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;

namespace Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

public abstract record SelectAttackedEntityResult
{
    public sealed record Success(EntityHolder Entity) : SelectAttackedEntityResult;

    public sealed record Failure(string Message) : SelectAttackedEntityResult;
}
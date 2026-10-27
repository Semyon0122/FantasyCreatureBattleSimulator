using Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;

namespace Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

public abstract record GetAttackingEntityResult
{
    public sealed record Success(EntityHolder Entity, int Number) : GetAttackingEntityResult;

    public sealed record Failure(string Message) : GetAttackingEntityResult;
}
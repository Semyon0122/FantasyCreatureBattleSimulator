using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

public abstract record GetAttackingEntityResult
{
    public sealed record Success(IEntity Entity, int Number) : GetAttackingEntityResult;

    public sealed record Failure(string Message) : GetAttackingEntityResult;
}
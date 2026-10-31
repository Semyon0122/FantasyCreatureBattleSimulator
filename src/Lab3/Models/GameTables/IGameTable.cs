using Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

public interface IGameTable
{
    string NickName { get; }

    GetAttackingEntityResult GetAttackingEntity(int number);

    GetAttackedEntityResult GetAttackedEntity();

    IGameTable Clone();
}
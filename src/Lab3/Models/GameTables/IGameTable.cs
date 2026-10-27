using Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

public interface IGameTable
{
    GetAttackingEntityResult GetAttackingEntity(int number);

    SelectAttackedEntityResult SelectAttackedEntity();
}
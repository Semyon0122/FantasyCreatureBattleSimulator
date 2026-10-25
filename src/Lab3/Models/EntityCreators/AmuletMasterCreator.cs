using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class AmuletMasterCreator : IEntityCreator
{
    private const int InitialAttackPower = 5;
    private const int InitialHealth = 2;

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return new AmuletMaster(
            attackPower ?? new AttackPower(InitialAttackPower),
            health ?? new HealthPoints(InitialHealth));
    }
}
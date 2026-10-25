using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class ViciousFighterCreator : IEntityCreator
{
    private const int InitialAttackPower = 1;
    private const int InitialHealth = 7;

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return new ViciousFighter(
            attackPower ?? new AttackPower(InitialAttackPower),
            health ?? new HealthPoints(InitialHealth));
    }
}
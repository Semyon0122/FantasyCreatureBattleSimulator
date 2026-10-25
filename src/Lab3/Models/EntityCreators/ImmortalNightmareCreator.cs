using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class ImmortalNightmareCreator : IEntityCreator
{
    private const int InitialAttackPower = 3;
    private const int InitialHealth = 4;

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return new ImmortalNightmare(
            attackPower ?? new AttackPower(InitialAttackPower),
            health ?? new HealthPoints(InitialHealth));
    }
}
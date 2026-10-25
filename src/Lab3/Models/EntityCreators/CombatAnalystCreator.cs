using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class CombatAnalystCreator : IEntityCreator
{
    private const int InitialAttackPower = 2;
    private const int InitialHealth = 4;

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return new CombatAnalyst(
            attackPower ?? new AttackPower(InitialAttackPower),
            health ?? new HealthPoints(InitialHealth));
    }
}
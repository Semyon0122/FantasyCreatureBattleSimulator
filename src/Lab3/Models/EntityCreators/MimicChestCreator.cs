using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class MimicChestCreator : IEntityCreator
{
    private const int InitialAttackPower = 1;
    private const int InitialHealth = 1;

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return new MimicChest(
            attackPower ?? new AttackPower(InitialAttackPower),
            health ?? new HealthPoints(InitialHealth));
    }
}
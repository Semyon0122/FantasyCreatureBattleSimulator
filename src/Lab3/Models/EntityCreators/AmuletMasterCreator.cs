using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class AmuletMasterCreator : IEntityCreator
{
    private const int InitialAttackPower = 5;
    private const int InitialHealth = 2;

    private readonly MagicShieldApplier _magicShieldModifier = new();
    private readonly AttackingProwessApplier _attackingProwessModifier = new();

    public IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null)
    {
        return _attackingProwessModifier.Apply(
               _magicShieldModifier.Apply(
                   new AmuletMaster(
                       attackPower ?? new AttackPower(InitialAttackPower),
                       health ?? new HealthPoints(InitialHealth))));
    }
}
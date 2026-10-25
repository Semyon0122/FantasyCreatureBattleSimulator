using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

public interface IEntityStep
{
    IModifierStep WithModifier(IModifierApplier modifierApplier);

    IHealthStep WithHealth(HealthPoints health);

    IAttackPowerStep WithAttackPower(AttackPower attackPower);

    IEntity Build();
}
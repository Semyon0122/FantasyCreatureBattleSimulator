using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

public interface IHealthStep
{
    IModifierStep WithModifier(IModifierApplier modifierApplier);

    IAttackPowerStep WithAttackPower(AttackPower attackPower);

    IEntity Build();
}
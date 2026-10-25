using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

public interface IAttackPowerStep
{
    IModifierStep WithModifier(IModifierApplier modifierApplier);

    IEntity Build();
}
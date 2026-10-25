using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

public interface IModifierStep
{
    IModifierStep WithModifier(IModifierApplier modifierApplier);

    IEntity Build();
}
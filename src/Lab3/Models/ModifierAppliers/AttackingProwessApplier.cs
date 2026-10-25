using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;

public class AttackingProwessApplier : IModifierApplier
{
    public IEntity Apply(IEntity entity)
    {
        return new AttackingProwess(entity);
    }
}
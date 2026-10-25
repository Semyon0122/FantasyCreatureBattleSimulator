using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;

public class MagicShieldApplier : IModifierApplier
{
    public IEntity Apply(IEntity entity)
    {
        return new MagicShield(entity);
    }
}
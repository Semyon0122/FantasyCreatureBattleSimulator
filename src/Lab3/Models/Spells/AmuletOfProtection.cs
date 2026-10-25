using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

public class AmuletOfProtection : ISpell
{
    public IEntity Apply(IEntity entity)
    {
        return new MagicShield(entity);
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

public class KalenPoison : ISpell
{
    public IEntity Apply(IEntity entity)
    {
        return new Vampirism(entity);
    }
}
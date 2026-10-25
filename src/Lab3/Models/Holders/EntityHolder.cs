using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;

public class EntityHolder : EntityDecorator
{
    public EntityHolder(IEntity entity) : base(entity) { }

    public void ApplySpell(ISpell spell)
    {
        Inner = spell.Apply(Inner);
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

public interface ISpell
{
    IEntity Apply(IEntity entity);
}
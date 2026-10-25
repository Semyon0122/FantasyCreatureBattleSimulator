using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

public class StaminaPotion : ISpell
{
    private const int RestoringHealth = 5;

    public IEntity Apply(IEntity entity)
    {
        entity.RestoreHealth(new HealthPoints(RestoringHealth));

        return entity;
    }
}
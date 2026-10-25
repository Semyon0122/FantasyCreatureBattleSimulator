using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;

public class PotionOfStrength : ISpell
{
    private const int AddingStrength = 5;

    public IEntity Apply(IEntity entity)
    {
        entity.AddAttack(new AttackPower(AddingStrength));

        return entity;
    }
}
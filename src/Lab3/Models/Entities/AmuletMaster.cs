using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class AmuletMaster : Entity
{
    public AmuletMaster(AttackPower attackPower, HealthPoints health) : base(attackPower, health) { }

    public override IEntity Clone()
    {
        return new AmuletMaster(AttackValue, Health);
    }
}
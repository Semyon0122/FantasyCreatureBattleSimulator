using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class MimicChest : Entity
{
    public MimicChest(AttackPower attackPower, HealthPoints health) : base(attackPower, health) { }

    public override void Attack(Entity target)
    {
        AttackPowerValue = AttackPower.Max(AttackPowerValue, target.AttackPowerValue);
        Health = HealthPoints.Max(Health, target.Health);

        base.Attack(target);
    }
}
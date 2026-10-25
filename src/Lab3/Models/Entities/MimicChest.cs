using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class MimicChest : Entity
{
    public MimicChest(HealthPoints health, HealthPoints attackPower) : base(health, attackPower) { }

    public override void Attack(Entity target)
    {
        AttackPower = HealthPoints.Max(AttackPower, target.AttackPower);
        Health = HealthPoints.Max(Health, target.Health);

        base.Attack(target);
    }
}
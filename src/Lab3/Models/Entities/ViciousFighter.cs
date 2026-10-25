using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class ViciousFighter : Entity
{
    private const int AttackBonus = 2;

    public ViciousFighter(AttackPower attackPower, HealthPoints health) : base(attackPower, health) { }

    public override void TakeDamage(AttackPower damage)
    {
        base.TakeDamage(damage);

        if (!IsDead())
        {
            AttackPowerValue *= AttackBonus;
        }
    }
}
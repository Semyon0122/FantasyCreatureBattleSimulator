using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class ViciousFighter : Entity
{
    private const int AttackBonus = 2;

    public ViciousFighter(HealthPoints health, HealthPoints attackPower) : base(health, attackPower) { }

    public override void TakeDamage(HealthPoints damage)
    {
        base.TakeDamage(damage);

        if (!IsDead())
        {
            AttackPower *= AttackBonus;
        }
    }
}
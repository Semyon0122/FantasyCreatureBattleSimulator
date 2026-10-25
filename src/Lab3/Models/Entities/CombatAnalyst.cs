using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class CombatAnalyst : Entity
{
    private const int AttackBonus = 3;

    public CombatAnalyst(AttackPower attackPower, HealthPoints health) : base(attackPower, health) { }

    public override void Attack(Entity target)
    {
        AttackPowerValue += AttackBonus;

        base.Attack(target);
    }
}
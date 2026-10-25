using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class CombatAnalyst : Entity
{
    private const int AttackBonus = 3;

    public CombatAnalyst(HealthPoints health, HealthPoints attackPower) : base(health, attackPower) { }

    public override void Attack(Entity target)
    {
        AttackPower += AttackBonus;

        base.Attack(target);
    }
}
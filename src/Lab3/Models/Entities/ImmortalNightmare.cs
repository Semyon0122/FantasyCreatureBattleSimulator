using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public class ImmortalNightmare : Entity
{
    private const int HealthAfterDeath = 1;

    private const int CounterInitialValue = 0;

    private int _counterRebirth;

    public ImmortalNightmare(HealthPoints health, HealthPoints attackPower) : base(health, attackPower)
    {
        _counterRebirth = CounterInitialValue;
    }

    public override void TakeDamage(HealthPoints damage)
    {
        base.TakeDamage(damage);

        if (IsDead() && _counterRebirth == 0)
        {
            Health = new HealthPoints(HealthAfterDeath);
            _counterRebirth++;
        }
    }
}
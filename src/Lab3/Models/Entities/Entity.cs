using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public abstract class Entity : IEntity
{
    public AttackPower AttackValue { get; protected set; }

    public HealthPoints Health { get; protected set; }

    protected Entity(AttackPower attackPower, HealthPoints health)
    {
        AttackValue = attackPower;
        Health = health;
    }

    public virtual void Attack(IEntity target)
    {
        target.TakeDamage(AttackValue);
    }

    public virtual void TakeDamage(AttackPower damage)
    {
        if (Health < damage)
        {
            Health = new(0);
            return;
        }

        Health -= damage;
    }

    public void RestoreHealth(HealthPoints health)
    {
        Health += health;
    }

    public void AddAttack(AttackPower attack)
    {
        AttackValue += attack;
    }

    public bool IsAbleToAttack()
    {
        return AttackValue > 0;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }

    public abstract IEntity Clone();
}
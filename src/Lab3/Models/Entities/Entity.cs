using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public abstract class Entity : IEntity
{
    public AttackPower AttackPowerValue { get; protected set; }

    public HealthPoints Health { get; protected set; }

    protected Entity(AttackPower attackPower, HealthPoints health)
    {
        AttackPowerValue = attackPower;
        Health = health;
    }

    public virtual void Attack(Entity target)
    {
        target.TakeDamage(AttackPowerValue);
    }

    public virtual void TakeDamage(AttackPower damage)
    {
        Health -= damage;
    }

    public void RestoreHealth(HealthPoints health)
    {
        Health += health;
    }

    public void AddAttack(AttackPower attack)
    {
        AttackPowerValue += attack;
    }

    public bool IsAbleToAttack()
    {
        return AttackPowerValue > 0;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public abstract class Entity : IEntity
{
    public HealthPoints Health { get; protected set; }

    public HealthPoints AttackPower { get; protected set; }

    protected Entity(HealthPoints health, HealthPoints attackPower)
    {
        Health = health;
        AttackPower = attackPower;
    }

    public virtual void Attack(Entity target)
    {
        target.TakeDamage(AttackPower);
    }

    public virtual void TakeDamage(HealthPoints damage)
    {
        Health -= damage;
    }

    public void RestoreHealth(HealthPoints health)
    {
        Health += health;
    }

    public void AddAttack(HealthPoints attack)
    {
        AttackPower += attack;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}
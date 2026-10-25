using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public abstract class EntityDecorator : IEntity
{
    protected IEntity Inner { get; set; }

    protected EntityDecorator(IEntity inner)
    {
        Inner = inner;
    }

    public virtual void Attack(Entity target)
    {
        Inner.Attack(target);
    }

    public virtual void TakeDamage(AttackPower damage)
    {
        Inner.TakeDamage(damage);
    }

    public void RestoreHealth(HealthPoints health)
    {
        Inner.RestoreHealth(health);
    }

    public void AddAttack(AttackPower attack)
    {
        Inner.AddAttack(attack);
    }

    public bool IsDead()
    {
        return Inner.IsDead();
    }
}
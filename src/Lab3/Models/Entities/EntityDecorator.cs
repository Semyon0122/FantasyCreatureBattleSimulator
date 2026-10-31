using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public abstract class EntityDecorator : IEntity
{
    public AttackPower AttackValue => Inner.AttackValue;

    public HealthPoints Health => Inner.Health;

    protected IEntity Inner { get; set; }

    protected EntityDecorator(IEntity inner)
    {
        Inner = inner;
    }

    public virtual void Attack(IEntity target)
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

    public bool IsAbleToAttack()
    {
        return Inner.IsAbleToAttack();
    }

    public bool IsDead()
    {
        return Inner.IsDead();
    }

    public abstract IEntity Clone();
}
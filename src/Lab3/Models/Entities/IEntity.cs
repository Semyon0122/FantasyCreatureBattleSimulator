using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public interface IEntity
{
    AttackPower AttackValue { get; }

    HealthPoints Health { get; }

    void Attack(IEntity target);

    void TakeDamage(AttackPower damage);

    void RestoreHealth(HealthPoints health);

    void AddAttack(AttackPower attack);

    bool IsAbleToAttack();

    bool IsDead();

    IEntity Clone();
}
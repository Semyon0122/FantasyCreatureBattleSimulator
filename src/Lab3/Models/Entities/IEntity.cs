using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public interface IEntity
{
    void Attack(Entity target);

    void TakeDamage(AttackPower damage);

    void RestoreHealth(HealthPoints health);

    void AddAttack(AttackPower attack);

    bool IsDead();
}
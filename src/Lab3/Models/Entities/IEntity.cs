using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

public interface IEntity
{
    void Attack(Entity target);

    void TakeDamage(HealthPoints damage);

    void RestoreHealth(HealthPoints health);

    void AddAttack(HealthPoints attack);

    bool IsDead();
}
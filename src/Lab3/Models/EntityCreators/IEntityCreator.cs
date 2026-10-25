using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public interface IEntityCreator
{
    IEntity Create(AttackPower? attackPower = null, HealthPoints? health = null);
}
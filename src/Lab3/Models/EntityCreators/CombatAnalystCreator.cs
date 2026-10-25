using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class CombatAnalystCreator : IEntityCreator
{
    private const int InitialAttackPower = 2;
    private const int InitialHealth = 4;

    public IEntity Create()
    {
        return new AmuletMaster(new HealthPoints(InitialHealth), new HealthPoints(InitialAttackPower));
    }
}
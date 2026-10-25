using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class ViciousFighterCreator : IEntityCreator
{
    private const int InitialAttackPower = 1;
    private const int InitialHealth = 7;

    public IEntity Create()
    {
        return new AmuletMaster(new HealthPoints(InitialHealth), new HealthPoints(InitialAttackPower));
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class AmuletMasterCreator : IEntityCreator
{
    private const int InitialAttackPower = 5;
    private const int InitialHealth = 2;

    public IEntity Create()
    {
        return new AmuletMaster(new HealthPoints(InitialHealth), new HealthPoints(InitialAttackPower));
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public class MimicChestCreator
{
    private const int InitialAttackPower = 1;
    private const int InitialHealth = 1;

    public IEntity Create()
    {
        return new AmuletMaster(new HealthPoints(InitialHealth), new HealthPoints(InitialAttackPower));
    }
}
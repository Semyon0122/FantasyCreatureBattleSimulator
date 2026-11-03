using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class CatalogTests
{
    [Fact]
    public void CreateEntity_ShouldSuccessful()
    {
        // arrange && act
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .Build();

        // assert
        Assert.Equal(entity.AttackValue, new AttackPower(1));
        Assert.Equal(entity.Health, new HealthPoints(1));
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class EntityTests
{
    [Fact]
    public void CombatAnalyst_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(100))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .Build();

        // act
        attackingEntity.Attack(entity);
        HealthPoints healthAfterFirstAttack = entity.Health;

        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(healthAfterFirstAttack, new HealthPoints(95));
        Assert.Equal(entity.Health, new HealthPoints(87));
    }

    [Fact]
    public void ViciousFighter_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Vicious Fighter")
            .WithHealth(new(100))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Vicious Fighter")
            .Build();

        // act
        attackingEntity.Attack(entity);
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(entity.AttackValue, new AttackPower(4));
    }

    [Fact]
    public void MimicChest_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Mimic Chest")
            .WithHealth(new(100))
            .WithAttackPower(new(100))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Mimic Chest")
            .Build();

        // act
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(attackingEntity.AttackValue, new AttackPower(100));
        Assert.Equal(attackingEntity.Health, new HealthPoints(100));
    }

    [Fact]
    public void ImmortalNightmare_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithAttackPower(new(100))
            .Build();

        // act
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(entity.Health, new HealthPoints(1));
    }

    [Fact]
    public void AmuletMaster_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Amulet Master")
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Amulet Master")
            .WithHealth(new(100))
            .WithAttackPower(new(1))
            .Build();

        // act
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(entity.Health, new HealthPoints(1));
    }
}
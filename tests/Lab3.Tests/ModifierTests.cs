using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class ModifierTests
{
    [Fact]
    public void EntityWithMagicShield_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(10))
            .WithAttackPower(new(10))
            .Build();

        // act
        attackingEntity.Attack(entity);
        HealthPoints healthAfterFirstAttack = entity.Health;

        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(healthAfterFirstAttack, new HealthPoints(1));
        Assert.Equal(entity.Health, new HealthPoints(0));
    }

    [Fact]
    public void EntityWithAttackingProwess_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .WithModifier(new AttackingProwessApplier())
            .Build();

        // act
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(entity.Health, new HealthPoints(8));
    }

    [Fact]
    public void EntityWithVampirism_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .WithModifier(new VampirismApplier())
            .Build();

        // act
        attackingEntity.Attack(entity);

        // assert
        Assert.Equal(entity.Health, new HealthPoints(9));
        Assert.Equal(attackingEntity.Health, new HealthPoints(11));
    }

    [Fact]
    public void EntityWithAllModifiers_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(10))
            .WithAttackPower(new(1))
            .WithModifier(new VampirismApplier())
            .WithModifier(new AttackingProwessApplier())
            .WithModifier(new MagicShieldApplier())
            .Build();

        // act
        attackingEntity.Attack(entity);
        entity.Attack(attackingEntity);

        // assert
        Assert.Equal(entity.Health, new HealthPoints(8));
        Assert.Equal(attackingEntity.Health, new HealthPoints(12));
    }
}
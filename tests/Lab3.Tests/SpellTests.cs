using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Spells;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SpellTests
{
    [Fact]
    public void PotionOfStrength_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        var entityHolder = new EntityHolder(entity);

        // act
        entityHolder.ApplySpell(new PotionOfStrength());

        // assert
        Assert.Equal(entityHolder.AttackValue, new AttackPower(8));
    }

    [Fact]
    public void StaminaPotion_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        var entityHolder = new EntityHolder(entity);

        // act
        entityHolder.ApplySpell(new StaminaPotion());

        // assert
        Assert.Equal(entityHolder.Health, new HealthPoints(9));
    }

    [Fact]
    public void AmuletOfProtection_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        var entityHolder = new EntityHolder(entity);

        // act
        entityHolder.ApplySpell(new AmuletOfProtection());
        attackingEntity.Attack(entityHolder);

        // assert
        Assert.Equal(entityHolder.Health, new HealthPoints(4));
    }

    [Fact]
    public void KalenPoison_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        IEntity attackingEntity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .Build();

        var entityHolder = new EntityHolder(attackingEntity);

        // act
        entityHolder.ApplySpell(new KalenPoison());
        entityHolder.Attack(entity);

        // assert
        Assert.Equal(entityHolder.Health, new HealthPoints(5));
    }
}
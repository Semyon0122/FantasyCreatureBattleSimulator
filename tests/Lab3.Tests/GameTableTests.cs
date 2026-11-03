using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class GameTableTests
{
    [Fact]
    public void AddInTable_ShouldFailed_WhenMoreThanSevenEntitiesOn()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table = new GameTable("gamer");

        // act
        for (int i = 0; i < 7; i++)
        {
            table.AddEntity(entity);
        }

        // assert
        Assert.Throws<ArgumentOutOfRangeException>(() => table.AddEntity(entity));
    }

    [Fact]
    public void EntitiesOnTableDoNotAffectCatalog_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table = new GameTable("gamer");
        table.AddEntity(entity);

        EntityHolder entityOnTable = table.GetEntity(0);

        IEntity sameEntityFromCatalogToCheck = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        // act
        entityOnTable.AddAttack(new AttackPower(10));

        // assert
        Assert.Equal(entityOnTable.AttackValue, new AttackPower(11));
        Assert.Equal(sameEntityFromCatalogToCheck.AttackValue, new AttackPower(1));
    }
}
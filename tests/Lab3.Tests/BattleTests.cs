using Itmo.ObjectOrientedProgramming.Lab3.Models.BattleLaunchers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class BattleTests
{
    [Fact]
    public void EntitiesInBattleDoNotAffectTable_ShouldSuccessful()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table1 = new GameTable("gamer1");
        var table2 = new GameTable("gamer2");
        table1.AddEntity(entity);
        table2.AddEntity(entity);

        var battle = new BattleLauncher();

        // act
        battle.LaunchBattle(table1, table2);

        // assert
        Assert.Equal(table1.GetEntity(0).Health, new HealthPoints(1));
        Assert.Equal(table2.GetEntity(0).Health, new HealthPoints(1));
    }

    [Fact]
    public void LaunchBattle_ShouldSuccessful_WhenPlayerWin()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table1 = new GameTable("gamer1");
        var table2 = new GameTable("gamer2");
        table1.AddEntity(entity);
        table2.AddEntity(entity);

        var battle = new BattleLauncher();

        // act
        string result = battle.LaunchBattle(table1, table2);

        // assert
        Assert.Equal($"Winner {table1.NickName}!", result);
    }

    [Fact]
    public void LaunchBattle_ShouldSuccessful_DrawWhenTwoPlayersCanNotAttack()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(1))
            .WithAttackPower(new(0))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table1 = new GameTable("gamer1");
        var table2 = new GameTable("gamer2");
        table1.AddEntity(entity);
        table2.AddEntity(entity);

        var battle = new BattleLauncher();

        // act
        string result = battle.LaunchBattle(table1, table2);

        // assert
        Assert.Equal($"Draw!", result);
    }

    [Fact]
    public void LaunchBattle_ShouldSuccessful_DrawWhenOnePlayerCanNotAttackAndAnotherHasNotTarget()
    {
        // arrange
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Combat Analyst")
            .WithHealth(new(0))
            .WithAttackPower(new(0))
            .WithModifier(new MagicShieldApplier())
            .Build();

        var table1 = new GameTable("gamer1");
        var table2 = new GameTable("gamer2");
        table1.AddEntity(entity);
        table2.AddEntity(entity);

        var battle = new BattleLauncher();

        // act
        string result = battle.LaunchBattle(table1, table2);

        // assert
        Assert.Equal($"Draw!", result);
    }
}
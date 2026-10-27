using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class CatalogTests
{
    [Fact]
    public void CreateEntity_ShouldSuccessful()
    {
        IEntity entity = TestConstants.EntityCatalog
            .CreateEntityByName("Immortal Nightmare")
            .WithHealth(new(1))
            .WithAttackPower(new(1))
            .WithModifier(new AttackingProwessApplier())
            .Build();
    }
}
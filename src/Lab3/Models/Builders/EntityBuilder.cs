using Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders;

public class EntityBuilder : ICreateStep, IEntityStep, IModifierStep, IHealthStep, IAttackPowerStep
{
    private readonly List<IModifierApplier> _modifiers = new();
    private IEntityCreator? _entityCreator;
    private HealthPoints? _health;
    private AttackPower? _attackPower;

    public static ICreateStep Create()
    {
        return new EntityBuilder();
    }

    public IEntityStep WithEntity(IEntityCreator entityCreator)
    {
        _entityCreator = entityCreator;
        return this;
    }

    public IHealthStep WithHealth(HealthPoints health)
    {
        _health = health;
        return this;
    }

    public IAttackPowerStep WithAttackPower(AttackPower attackPower)
    {
        _attackPower = attackPower;
        return this;
    }

    public IModifierStep WithModifier(IModifierApplier modifierApplier)
    {
        _modifiers.Add(modifierApplier);
        return this;
    }

    public IEntity Build()
    {
        if (_entityCreator is null)
        {
            throw new ArgumentNullException("Entity creator in builder is null!");
        }

        IEntity entity = _entityCreator.Create(_attackPower, _health);

        foreach (IModifierApplier applier in _modifiers)
        {
            applier.Apply(entity);
        }

        return entity;
    }
}
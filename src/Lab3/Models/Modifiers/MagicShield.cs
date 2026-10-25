using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

public class MagicShield : EntityDecorator
{
    private bool _isUsed;

    public MagicShield(IEntity inner) : base(inner)
    {
        _isUsed = false;
    }

    public override void TakeDamage(AttackPower damage)
    {
        if (!_isUsed)
        {
            _isUsed = true;
            return;
        }

        base.TakeDamage(damage);
    }
}
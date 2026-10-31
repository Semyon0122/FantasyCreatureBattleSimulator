using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

public class AttackingProwess : EntityDecorator
{
    public AttackingProwess(IEntity inner) : base(inner) { }

    public override void Attack(IEntity target)
    {
        base.Attack(target);

        if (!Inner.IsDead())
        {
            base.Attack(target);
        }
    }

    public override IEntity Clone()
    {
        return new AttackingProwess(Inner.Clone());
    }
}
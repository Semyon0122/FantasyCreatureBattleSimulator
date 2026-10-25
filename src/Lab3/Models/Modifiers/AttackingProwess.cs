using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

public class AttackingProwess : EntityDecorator
{
    public AttackingProwess(IEntity inner) : base(inner) { }

    public override void Attack(Entity target)
    {
        base.Attack(target);

        if (!Inner.IsDead())
        {
            base.Attack(target);
        }
    }
}
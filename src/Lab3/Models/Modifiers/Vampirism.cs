using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Modifiers;

public class Vampirism : EntityDecorator
{
    private const int RestoringHealth = 1;

    public Vampirism(IEntity inner) : base(inner) { }

    public override void Attack(Entity target)
    {
        base.Attack(target);

        RestoreHealth(new HealthPoints(RestoringHealth));
    }
}
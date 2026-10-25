using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ModifierAppliers;

public interface IModifierApplier
{
    IEntity Apply(IEntity entity);
}
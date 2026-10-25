using Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

public interface ICreateStep
{
    IEntityStep WithEntity(IEntityCreator entityCreator);
}
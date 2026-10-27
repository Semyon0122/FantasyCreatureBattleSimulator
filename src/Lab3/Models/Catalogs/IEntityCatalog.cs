using Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Catalogs;

public interface IEntityCatalog
{
    IEntityStep CreateEntityByName(string name);
}
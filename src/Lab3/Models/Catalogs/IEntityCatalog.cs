using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Catalogs;

public interface IEntityCatalog
{
    IEntity CreateEntityByName(string name);
}
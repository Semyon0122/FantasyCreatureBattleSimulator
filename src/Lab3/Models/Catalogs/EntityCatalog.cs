using Itmo.ObjectOrientedProgramming.Lab3.Models.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Builders.EntityBuilderSteps;
using Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Catalogs;

public class EntityCatalog : IEntityCatalog
{
    private readonly Dictionary<string, IEntityCreator> _storage;

    public EntityCatalog(IDictionary<string, IEntityCreator> storage)
    {
        _storage = storage.ToDictionary();
    }

    public IEntityStep CreateEntityByName(string name)
    {
        _storage.TryGetValue(name, out IEntityCreator? entityCreator);

        if (entityCreator is null)
        {
            throw new KeyNotFoundException($"Key {name} is not found!");
        }

        return EntityBuilder.Create().WithEntity(entityCreator);
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Catalogs;

public class EntityCatalog : IEntityCatalog
{
    private readonly Dictionary<string, IEntity> _storage;

    public EntityCatalog(IDictionary<string, IEntity> storage)
    {
        _storage = storage.ToDictionary();
    }

    public IEntity CreateEntityByName(string name)
    {
        _storage.TryGetValue(name, out IEntity? entity);

        if (entity is null)
        {
            throw new KeyNotFoundException($"Key {name} is not found!");
        }

        return entity;
    }
}
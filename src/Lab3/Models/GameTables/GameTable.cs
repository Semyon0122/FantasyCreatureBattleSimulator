using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Holders;
using Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;
using System.Security.Cryptography;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

public class GameTable : IGameTable
{
    private const int MaxEntityCount = 7;

    private readonly List<EntityHolder> _storage;

    public string NickName { get; }

    public GameTable(string nickName)
    {
        _storage = new List<EntityHolder>();
        NickName = nickName;
    }

    public void AddEntity(IEntity entity)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(_storage.Count, MaxEntityCount, "Table is full!");

        _storage.Add(new EntityHolder(entity));
    }

    public EntityHolder GetEntity(int number)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(number, _storage.Count, "Out of range index!");
        ArgumentOutOfRangeException.ThrowIfLessThan(number, 0, "Out of range index!");

        return _storage[number];
    }

    public GetAttackingEntityResult GetAttackingEntity(int number)
    {
        for (int i = number; i < number + _storage.Count; i++)
        {
            EntityHolder entity = _storage[i % _storage.Count];

            if (entity.IsAbleToAttack() && !entity.IsDead())
            {
                return new GetAttackingEntityResult.Success(entity, (i + 1) % _storage.Count);
            }
        }

        return new GetAttackingEntityResult.Failure("No entities can attack!");
    }

    public GetAttackedEntityResult GetAttackedEntity()
    {
        var livingEntities = new List<EntityHolder>();

        foreach (EntityHolder livingEntity in _storage)
        {
            if (!livingEntity.IsDead())
            {
                livingEntities.Add(livingEntity);
            }
        }

        if (livingEntities.Count == 0)
        {
            return new GetAttackedEntityResult.Failure("There is no living entities remain!");
        }

        EntityHolder entity = livingEntities[RandomNumberGenerator.GetInt32(livingEntities.Count)];

        return new GetAttackedEntityResult.Success(entity);
    }

    public IGameTable Clone()
    {
        var newTable = new GameTable(NickName);

        foreach (EntityHolder entity in _storage)
        {
            newTable.AddEntity((EntityHolder)entity.Clone());
        }

        return newTable;
    }
}
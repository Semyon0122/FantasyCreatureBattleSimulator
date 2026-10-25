using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

public interface IEntityCreator
{
    IEntity Create();
}
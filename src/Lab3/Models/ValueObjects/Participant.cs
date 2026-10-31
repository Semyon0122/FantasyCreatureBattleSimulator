using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public class Participant
{
    public int NextAttackerPosition { get; set; }

    public IGameTable Table { get; }

    public Participant(IGameTable table)
    {
        Table = table;
        NextAttackerPosition = 0;
    }
}
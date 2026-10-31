namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public class RolesInBattle
{
    public Participant Current { get; private set; }

    public Participant Opponent { get; private set; }

    public RolesInBattle(Participant current, Participant opponent)
    {
        Current = current;
        Opponent = opponent;
    }

    public void ChangeRoles()
    {
        (Current, Opponent) = (Opponent, Current);
    }
}
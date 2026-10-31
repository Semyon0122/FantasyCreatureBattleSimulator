using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Battle;

public interface IBattle
{
    string LaunchBattle(IGameTable player1, IGameTable player2);
}
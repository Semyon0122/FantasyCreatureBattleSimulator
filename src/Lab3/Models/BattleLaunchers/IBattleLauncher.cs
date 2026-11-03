using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.BattleLaunchers;

public interface IBattleLauncher
{
    string LaunchBattle(IGameTable player1, IGameTable player2);
}
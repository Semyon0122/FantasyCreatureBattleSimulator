using Itmo.ObjectOrientedProgramming.Lab3.Models.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.GameTables;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.ResultTypes.GameTableResultTypes;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Battle;

public class Battle : IBattle
{
    public string LaunchBattle(IGameTable player1, IGameTable player2)
    {
        IGameTable playerClone1 = player1.Clone();
        IGameTable playerClone2 = player2.Clone();

        var playersRoles = new RolesInBattle(new(playerClone1), new(playerClone2));
        int skipTurnCounter = 0;
        string battleResult = string.Empty;

        while (string.IsNullOrEmpty(battleResult))
        {
            GetAttackingEntityResult attackingEntityResult =
                playersRoles.Current.Table.GetAttackingEntity(playersRoles.Current.NextAttackerPosition);

            GetAttackedEntityResult attackedEntityResult =
                playersRoles.Opponent.Table.GetAttackedEntity();

            switch (attackingEntityResult, attackedEntityResult)
            {
                case (
                    GetAttackingEntityResult.Success successAttacking,
                    GetAttackedEntityResult.Success successAttacked):

                    skipTurnCounter = 0;

                    IEntity attackingEntity = successAttacking.Entity;
                    IEntity attackedEntity = successAttacked.Entity;

                    attackingEntity.Attack(attackedEntity);

                    playersRoles.Current.NextAttackerPosition = successAttacking.Number;
                    break;

                case (GetAttackingEntityResult.Success, GetAttackedEntityResult.Failure):

                    battleResult = $"Winner {playersRoles.Current.Table.NickName}!";
                    break;

                case (GetAttackingEntityResult.Failure, GetAttackedEntityResult.Success):

                    skipTurnCounter++;

                    if (skipTurnCounter == 2)
                    {
                        battleResult = "Draw!";
                    }

                    break;

                case (GetAttackingEntityResult.Failure, GetAttackedEntityResult.Failure):

                    battleResult = "Draw!";
                    break;
            }

            playersRoles.ChangeRoles();
        }

        return battleResult;
    }
}
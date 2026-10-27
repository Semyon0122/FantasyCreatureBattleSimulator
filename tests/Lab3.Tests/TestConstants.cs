using Itmo.ObjectOrientedProgramming.Lab3.Models.Catalogs;
using Itmo.ObjectOrientedProgramming.Lab3.Models.EntityCreators;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public static class TestConstants
{
    // entity creators
    public static readonly IEntityCreator AmuletMaster = new AmuletMasterCreator();
    public static readonly IEntityCreator CombatAnalyst = new CombatAnalystCreator();
    public static readonly IEntityCreator ImmortalNightmare = new ImmortalNightmareCreator();
    public static readonly IEntityCreator MimicChest = new MimicChestCreator();
    public static readonly IEntityCreator ViciousFighter = new ViciousFighterCreator();

    public static readonly Dictionary<string, IEntityCreator> CreatorsStorage = new()
    {
        ["Amulet Master"] = AmuletMaster,
        ["Combat Analyst"] = CombatAnalyst,
        ["Immortal Nightmare"] = ImmortalNightmare,
        ["Mimic Chest"] = MimicChest,
        ["Vicious Fighter"] = ViciousFighter,
    };

    // entity catalog
    public static readonly IEntityCatalog EntityCatalog = new EntityCatalog(CreatorsStorage);
}
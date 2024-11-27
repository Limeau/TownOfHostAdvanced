using AmongUs.GameOptions;
using TownOfHost.Modules;
using TownOfHost.Roles.Core;
using TownOfHost.Roles.Core.Interfaces;

namespace TownOfHost.Roles.Impostor;

public sealed class CovenLeader : RoleBase, IImpostor
{
    public static readonly SimpleRoleInfo RoleInfo =
        SimpleRoleInfo.Create(
            typeof(CovenLeader),
            player => new CovenLeader(player),
            CustomRoles.CovenLeader,
            () => RoleTypes.Impostor,
            CustomRoleTypes.Coven,
            60000,
            SetupOptionItems,
            "co",
            introSound: () => PlayerControl.LocalPlayer.KillSfx
        );
    public CovenLeader(PlayerControl player)
    : base(
        RoleInfo,
        player
    )
    {
    }
    private static void SetupOptionItems()
    {
    }
}
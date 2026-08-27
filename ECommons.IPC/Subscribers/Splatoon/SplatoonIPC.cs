using Dalamud.Game.ClientState.Objects.SubKinds;
using ECommons.EzIpcManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommons.IPC.Subscribers.Splatoon;

public class SplatoonIPC : IPCBase
{
    public SplatoonIPC()
    {
    }

    public SplatoonIPC(SafeWrapper wrapper) : base(wrapper)
    {
    }

    public override string InternalName { get; } = "Splatoon";

    [EzIPC("GetRoleOf")] public Func<IPlayerCharacter, RolePosition> GetRoleOf;
}

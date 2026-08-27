using ECommons.EzIpcManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommons.IPC.Subscribers.Battlevest;

public class BattlevestIPC : IPCBase
{
    public BattlevestIPC()
    {
    }

    public BattlevestIPC(SafeWrapper wrapper) : base(wrapper)
    {
    }

    public override string InternalName { get; } = "Battlevest";
    [EzIPC] public Func<bool> IsEnabled { get; private set; }
    [EzIPC] public Action<string> BeginPlanFromString { get; private set; }
}

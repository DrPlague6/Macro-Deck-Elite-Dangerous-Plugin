using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NeonOwl.Elite.Utils;
using SuchByte.MacroDeck.InternalPlugins.DevicePlugin;
using SuchByte.MacroDeck.Logging;
using WindowsInput;

namespace NeonOwl.Elite.Actions
{
    public class CycleFireGroupPrevious : PluginAction
    {
        public override string Name => "Cycle Previous Fire Group";
        public override string Description => "Cycles the fire group to the previous one.";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new KeyboardUtils().TriggerKeyBinding(PluginInstance.EliteBindings.UserBindings.CycleFireGroupPrevious);
        }
    }
}
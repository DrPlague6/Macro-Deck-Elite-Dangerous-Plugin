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
    public class SetSpeed100 : PluginAction
    {
        public override string Name => "Set Speed 100";
        public override string Description => "Set Speed 100%.";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new KeyboardUtils().TriggerKeyBinding(PluginInstance.EliteBindings.UserBindings.SetSpeed100);
        }
    }
}
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
    public class ExplorationFSSQuit : PluginAction
    {
        public override string Name => "Quit FSS Exploration Mode";
        public override string Description => "Quit FSS Exploration Mode";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new KeyboardUtils().TriggerKeyBinding(PluginInstance.EliteBindings.UserBindings.ExplorationFSSQuit);
        }
    }
}
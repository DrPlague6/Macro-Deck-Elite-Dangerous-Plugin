﻿using SuchByte.MacroDeck.ActionButton;
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
    public class HyperSuperCombination : PluginAction
    {
        public override string Name => "Hyperspace Supercruise Combination";
        public override string Description => "Hyperspace Supercruise Combination.";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new KeyboardUtils().TriggerKeyBinding(PluginInstance.EliteBindings.UserBindings.HyperSuperCombination);
        }
    }
}
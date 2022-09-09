using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NeonOwl.Elite.Utils;
using SuchByte.MacroDeck.Logging;
using WindowsInput;

namespace NeonOwl.Elite.Actions
{
    public class ToggleLandingGear : PluginAction
    {
        public override string Name => "Toggle Landing Gear";
        public override string Description => "Deploy or retract landing gear.";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            MacroDeckLogger.Info(PluginInstance.Main,
                PluginInstance.EliteBindings.UserBindings.LandingGearToggle.Secondary.Key);
            KeyConverter kc = new KeyConverter();
            VirtualKeyCode key = kc.GetKey(PluginInstance.EliteBindings.UserBindings.LandingGearToggle.Primary.Key);

            if (key == VirtualKeyCode.None)
                key = kc.GetKey(PluginInstance.EliteBindings.UserBindings.LandingGearToggle.Secondary.Key);
            if (key == VirtualKeyCode.None)
            {
                MacroDeckLogger.Error(PluginInstance.Main,
                    "Elite Dangerous shortuct for landing gear toggle not found. Bind a key in the game settings.");
                return;
            }

            PluginInstance.Input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LSHIFT, key);
        }
    }
}
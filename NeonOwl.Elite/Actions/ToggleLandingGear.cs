using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WindowsInput;

namespace NeonOwl.Elite.Actions
{
    public class ToggleLandingGear : PluginAction
    {
        public override string Name => "Toggle Landing Gear";
        public override string Description => "Deploy or retract landing gear.";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new InputSimulator().Keyboard.ModifiedKeyStroke(VirtualKeyCode.LSHIFT, VirtualKeyCode.VK_A).Sleep(100);
        }
    }
}

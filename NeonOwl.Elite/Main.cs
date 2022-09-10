using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using NeonOwl.Elite.Actions;
using NeonOwl.Elite.Utils;
using SuchByte.MacroDeck.Logging;
using WindowsInput;
using System;
using System.Windows.Forms;

namespace NeonOwl.Elite
{
    public static class PluginInstance
    {
        public static Main Main = new Main();
        public static readonly InputSimulator Input = new InputSimulator();
        public static readonly EliteUtils EliteBindings = new EliteUtils();
    }

    public class Main : MacroDeckPlugin
    {
        public override void Enable()
        {
            if (!PluginInstance.EliteBindings.CheckForConfig())
            {
                MacroDeckLogger.Error(this, "Elite Dangerous is not installed. Plugin will not work.");
                return;
            }

            PluginInstance.EliteBindings.LoadConfig();

            this.Actions = new List<PluginAction>
            {
                new ToggleLandingGear(),
                new ToggleCargoScoop(),
                new ShipSpotLightToggle(),
                new Hyperspace(),
                new Supercruise(),
            };
        }
    }
}
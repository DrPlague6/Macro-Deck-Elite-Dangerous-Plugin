using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using NeonOwl.Elite.Actions;
using WindowsInput;

namespace NeonOwl.Elite
{
    public class Main : MacroDeckPlugin
    {
        public override void Enable()
        {
            this.Actions = new List<PluginAction>
            {
                new ToggleLandingGear(),
            };
        }
    }
}

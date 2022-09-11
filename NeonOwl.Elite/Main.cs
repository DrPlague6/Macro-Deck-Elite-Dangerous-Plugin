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
        public System.Timers.Timer TickTimer;

        public override void Enable()
        {
            if (!PluginInstance.EliteBindings.CheckForConfig())
            {
                MacroDeckLogger.Error(this, "Elite Dangerous is not installed. Plugin will not work.");
                return;
            }

            TickTimer = new System.Timers.Timer()
            {
                Enabled = true,
                Interval = 10000,
            };
            this.TickTimer.Start();

            this.TickTimer.Elapsed += (sender, e) => { PluginInstance.EliteBindings.LoadConfig(); };
            PluginInstance.EliteBindings.LoadConfig();

            this.Actions = new List<PluginAction>
            {
                new SetSpeedZero(),
                new SetSpeed25(),
                new SetSpeed50(),
                new SetSpeed75(),
                new SetSpeed100(),
                new ToggleFlightAssist(),
                new HyperSuperCombination(),
                new Supercruise(),
                new Hyperspace(),
                new OrbitLinesToggle(),
                new SelectTarget(),
                new CycleNextTarget(),
                new CyclePreviousTarget(),
                new SelectHighestThreat(),
                new CycleNextHostileTarget(),
                new CyclePreviousHostileTarget(),
                new TargetWingman0(),
                new TargetWingman1(),
                new TargetWingman2(),
                new WingNavLock(),
                new CycleNextSubsystem(),
                new CyclePreviousSubsystem(),
                new TargetNextRouteSystem(),
                new CycleFireGroupNext(),
                new CycleFireGroupPrevious(),
                new DeployHardpointToggle(),
                new DeployHeatSink(),
                new ShipSpotLightToggle(),
                new RadarIncreaseRange(),
                new RadarDecreaseRange(),
                new IncreaseEnginesPower(),
                new IncreaseWeaponsPower(),
                new IncreaseSystemsPower(),
                new ResetPowerDistribution(),
                new ToggleCargoScoop(),
                new EjectAllCargo(),
                new ToggleLandingGear(),
                new UseShieldCell(),
                new FireChaffLauncher(),
                new NightVisionToggle(),
                new FocusLeftPanel(),
                new FocusCommsPanel(),
                new QuickCommsPanel(),
                new FocusRightPanel(),
                new GalaxyMapOpen(),
                new SystemMapOpen(),
                new ExplorationFSSEnter(),
                new ExplorationFSSQuit(),
                new OrderFocusTarget(),
                new OpenOrders(),
            };
        }
    }
}
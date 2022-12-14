using System.Collections.Generic;
using System.Threading;
using SuchByte.MacroDeck.Logging;
using WindowsInput;

namespace NeonOwl.Elite.Utils
{
    public class KeyboardUtils
    {
        public VirtualKeyCode GetKey(string key)
        {
            switch (key)
            {
                case "Key_A":
                    return VirtualKeyCode.VK_A;
                case "Key_B":
                    return VirtualKeyCode.VK_B;
                case "Key_C":
                    return VirtualKeyCode.VK_C;
                case "Key_D":
                    return VirtualKeyCode.VK_D;
                case "Key_E":
                    return VirtualKeyCode.VK_E;
                case "Key_F":
                    return VirtualKeyCode.VK_F;
                case "Key_G":
                    return VirtualKeyCode.VK_G;
                case "Key_H":
                    return VirtualKeyCode.VK_H;
                case "Key_I":
                    return VirtualKeyCode.VK_I;
                case "Key_J":
                    return VirtualKeyCode.VK_J;
                case "Key_K":
                    return VirtualKeyCode.VK_K;
                case "Key_L":
                    return VirtualKeyCode.VK_L;
                case "Key_M":
                    return VirtualKeyCode.VK_M;
                case "Key_N":
                    return VirtualKeyCode.VK_N;
                case "Key_O":
                    return VirtualKeyCode.VK_O;
                case "Key_P":
                    return VirtualKeyCode.VK_P;
                case "key_Q":
                    return VirtualKeyCode.VK_Q;
                case "Key_R":
                    return VirtualKeyCode.VK_R;
                case "Key_S":
                    return VirtualKeyCode.VK_S;
                case "Key_T":
                    return VirtualKeyCode.VK_T;
                case "Key_U":
                    return VirtualKeyCode.VK_U;
                case "Key_V":
                    return VirtualKeyCode.VK_V;
                case "Key_W":
                    return VirtualKeyCode.VK_W;
                case "Key_X":
                    return VirtualKeyCode.VK_X;
                case "Key_Y":
                    return VirtualKeyCode.VK_Y;
                case "Key_Z":
                    return VirtualKeyCode.VK_Z;
                case "Key_0":
                    return VirtualKeyCode.VK_0;
                case "Key_1":
                    return VirtualKeyCode.VK_1;
                case "Key_2":
                    return VirtualKeyCode.VK_2;
                case "Key_3":
                    return VirtualKeyCode.VK_3;
                case "Key_4":
                    return VirtualKeyCode.VK_4;
                case "Key_5":
                    return VirtualKeyCode.VK_5;
                case "Key_6":
                    return VirtualKeyCode.VK_6;
                case "Key_7":
                    return VirtualKeyCode.VK_7;
                case "Key_8":
                    return VirtualKeyCode.VK_8;
                case "Key_9":
                    return VirtualKeyCode.VK_9;
                case "Key_F1":
                    return VirtualKeyCode.F1;
                case "Key_F2":
                    return VirtualKeyCode.F2;
                case "Key_F3":
                    return VirtualKeyCode.F3;
                case "Key_F4":
                    return VirtualKeyCode.F4;
                case "Key_F5":
                    return VirtualKeyCode.F5;
                case "Key_F6":
                    return VirtualKeyCode.F6;
                case "Key_F7":
                    return VirtualKeyCode.F7;
                case "Key_F8":
                    return VirtualKeyCode.F8;
                case "Key_F9":
                    return VirtualKeyCode.F9;
                case "Key_F10":
                    return VirtualKeyCode.F10;
                case "Key_F11":
                    return VirtualKeyCode.F11;
                case "Key_F12":
                    return VirtualKeyCode.F12;
                case "Key_Equals":
                    return VirtualKeyCode.OEM_PLUS;
                case "Key_Minus":
                    return VirtualKeyCode.OEM_MINUS;
                case "Key_Delete":
                    return VirtualKeyCode.DELETE;
                case "Key_PageUp":
                    return VirtualKeyCode.PRIOR;
                case "Key_PageDown":
                    return VirtualKeyCode.NEXT;
                case "Key_Home":
                    return VirtualKeyCode.HOME;
                case "Key_BackSlash":
                    return VirtualKeyCode.OEM_5;
                case "Key_End":
                    return VirtualKeyCode.END;
                case "Key_Enter":
                    return VirtualKeyCode.RETURN;
                case "Key_Tab":
                    return VirtualKeyCode.TAB;
                case "Key_Numpad_0":
                    return VirtualKeyCode.NUMPAD0;
                case "Key_Numpad_1":
                    return VirtualKeyCode.NUMPAD1;
                case "Key_Numpad_2":
                    return VirtualKeyCode.NUMPAD2;
                case "Key_Numpad_3":
                    return VirtualKeyCode.NUMPAD3;
                case "Key_Numpad_4":
                    return VirtualKeyCode.NUMPAD4;
                case "Key_Numpad_5":
                    return VirtualKeyCode.NUMPAD5;
                case "Key_Numpad_6":
                    return VirtualKeyCode.NUMPAD6;
                case "Key_Numpad_7":
                    return VirtualKeyCode.NUMPAD7;
                case "Key_Numpad_8":
                    return VirtualKeyCode.NUMPAD8;
                case "Key_Numpad_9":
                    return VirtualKeyCode.NUMPAD9;
                case "Key_Numpad_Divide":
                    return VirtualKeyCode.DIVIDE;
                case "Key_Numpad_Multiply":
                    return VirtualKeyCode.MULTIPLY;
                case "Key_LeftControl":
                    return VirtualKeyCode.LCONTROL;
                case "Key_RightControl":
                    return VirtualKeyCode.RCONTROL;
                case "Key_LeftShift":
                    return VirtualKeyCode.LSHIFT;
                case "Key_RightShift":
                    return VirtualKeyCode.RSHIFT;
                case "Key_LeftAlt":
                    return VirtualKeyCode.LMENU;
                case "Key_RightAlt":
                    return VirtualKeyCode.RMENU;
                case "Key_Apostrophe":
                    return VirtualKeyCode.OEM_7;
                case "Key_Semicolon":
                    return VirtualKeyCode.OEM_1;
                case "Key_LeftBracket":
                    return VirtualKeyCode.OEM_4;
                case "Key_RightBracket":
                    return VirtualKeyCode.OEM_6;
                case "Key_Comma":
                    return VirtualKeyCode.OEM_COMMA;
                default:
                    return VirtualKeyCode.None;
            }
        }

        public void TriggerKeyBinding(StandardBindingInfo standardBinding)
        {
            List<VirtualKeyCode> modifierKeys = new List<VirtualKeyCode>();
            VirtualKeyCode triggerKey;
            if (standardBinding.Primary.Device == "Keyboard")
            {
                triggerKey = GetKey(standardBinding.Primary.Key);
                foreach (Binding modifier in standardBinding.Primary.Modifier)
                {
                    VirtualKeyCode tmp = GetKey(modifier.Key);
                    if (tmp == VirtualKeyCode.None)
                        continue;
                    modifierKeys.Add(tmp);
                }
            }
            else if (standardBinding.Secondary.Device == "Keyboard")
            {
                triggerKey = GetKey(standardBinding.Secondary.Key);
                foreach (Binding modifier in standardBinding.Secondary.Modifier)
                {
                    VirtualKeyCode tmp = GetKey(modifier.Key);
                    if (tmp == VirtualKeyCode.None)
                        continue;
                    modifierKeys.Add(tmp);
                }
            }
            else
            {
                MacroDeckLogger.Error(PluginInstance.Main,
                    "No keyboard binding found for this action.");
                return;
            }

            foreach (VirtualKeyCode mod in modifierKeys)
            {
                PluginInstance.Input.Keyboard.KeyDown(mod);
            }

            Thread.Sleep(200);
            PluginInstance.Input.Keyboard.KeyDown(triggerKey);

            Thread.Sleep(200);
            PluginInstance.Input.Keyboard.KeyUp(triggerKey);

            foreach (VirtualKeyCode mod in modifierKeys)
            {
                PluginInstance.Input.Keyboard.KeyUp(mod);
            }
        }
    }
}
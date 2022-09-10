using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using SuchByte.MacroDeck.InternalPlugins.DevicePlugin;
using SuchByte.MacroDeck.Logging;
using WindowsInput;

namespace NeonOwl.Elite.Utils
{
    public class EliteUtils
    {
        string _bindingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            @"Frontier Developments\Elite Dangerous\Options\Bindings");

        UserBindings _userBindings;

        public UserBindings UserBindings
        {
            get => _userBindings;
        }

        //Check if file directory exists
        public bool CheckForConfig()
        {
            if (!Directory.Exists(_bindingPath))
                return false;
            _bindingPath = Path.Combine(_bindingPath, "Custom.4.0.binds");
            if (!File.Exists(_bindingPath))
            {
                _bindingPath = _bindingPath.Replace("Custom.4.0.binds", "Custom.3.0.binds");
                if (!File.Exists(_bindingPath))
                    return false;
            }

            return true;
        }

        public void LoadConfig()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserBindings));
            StreamReader reader = new StreamReader(_bindingPath);
            _userBindings = (UserBindings)serializer.Deserialize(reader);
            reader.Close();
            MacroDeckLogger.Info(PluginInstance.Main, "Loaded Elite Dangerous config");
        }
        
    }
}
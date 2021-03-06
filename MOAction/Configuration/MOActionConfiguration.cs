﻿using System;
using System.IO;
using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;

namespace MOActionPlugin
{
    [Serializable]
    public class MOActionConfiguration : IPluginConfiguration
    {
        public MOActionPreset MoPresets { get; set; }
        int IPluginConfiguration.Version { get; set; }
    }
}

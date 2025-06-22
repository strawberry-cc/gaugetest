using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
using System.Numerics;

namespace RollingBattery;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;
    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    public float TextScale = 1.0f;
    public float TextPosX = 400f;
    public float TextPosY = 400f;
    public Vector4 TextColor { get; set; } = new Vector4(1f, 1f, 0f, 1f); // default yellow

    // the below exist just to make saving less cumbersome
    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}

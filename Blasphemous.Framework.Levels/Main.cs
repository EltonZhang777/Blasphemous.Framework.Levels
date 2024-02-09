﻿using BepInEx;

namespace Blasphemous.Framework.Levels;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "2.0.2")]
public class Main : BaseUnityPlugin
{
    public static LevelFramework LevelFramework { get; private set; }

    private void Start()
    {
        LevelFramework = new LevelFramework();
    }
}

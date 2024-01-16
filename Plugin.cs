using BepInEx.Logging;
using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaptlandFreeBasicItems.Patches;
using BepInEx.Configuration;

namespace CaptlandFreeBasicItems
{
    public class Config
    {
        public static ConfigEntry<int> configWalkieTalkiePrice;
        public static ConfigEntry<int> configFlashlightPrice;
        public static ConfigEntry<int> configShovelPrice;
        public static ConfigEntry<int> configLockpickerPrice;
        public static ConfigEntry<int> configProFlashlightPrice;
        public static ConfigEntry<int> configStunGrenadePrice;
        public static ConfigEntry<int> configBoomboxPrice;
        public static ConfigEntry<int> configInhalantPrice;
        public static ConfigEntry<int> configZapGunPrice;
        public static ConfigEntry<int> configJetpackPrice;
        public static ConfigEntry<int> configExtensionLadderPrice;
        public static ConfigEntry<int> configRadarBoosterPrice;
        public static ConfigEntry<int> configSprayPaintPrice;

        public Config(ConfigFile cfg)
        {
            configWalkieTalkiePrice = cfg.Bind(
                "General",
                "WalkieTalkiePrice",
                0,
                "Price of Walkie-Talkie"
                );
            configFlashlightPrice = cfg.Bind(
                "General",
                "FlashlightPrice",
                0,
                "Price of Flashlight"
                );
            configShovelPrice = cfg.Bind(
                "General",
                "ShovelPrice",
                0,
                "Price of Shovel"
                );
            configLockpickerPrice = cfg.Bind(
                "General",
                "LockerpickerPrice",
                0,
                "Price of Lockpicker"
                );
            configProFlashlightPrice = cfg.Bind(
                "General",
                "ProFlashlightPrice",
                0,
                "Price of Pro Flashlight"
                );
            configStunGrenadePrice = cfg.Bind(
                "General",
                "StunGrenadePrice",
                0,
                "Price of Stun Grenade"
                );
            configBoomboxPrice = cfg.Bind(
                "General",
                "BoomboxPrice",
                0,
                "Price of Boombox"
                );
            configInhalantPrice = cfg.Bind(
                "General",
                "InhalantPrice",
                0,
                "Price of Inhalant"
                );
            configZapGunPrice = cfg.Bind(
                "General",
                "ZapGunPrice",
                0,
                "Price of Zap Gun"
                );
            configJetpackPrice = cfg.Bind(
                "General",
                "JetpackPrice",
                0,
                "Price of Jetpack"
                );
            configExtensionLadderPrice = cfg.Bind(
                "General",
                "ExtensionLadderPrice",
                0,
                "Price of Extension Ladder"
                );
            configRadarBoosterPrice = cfg.Bind(
                "General",
                "RadarBoosterPrice",
                0,
                "Price of Radar Booster"
                );
            configSprayPaintPrice = cfg.Bind(
                "General",
                "SprayPaintPrice",
                0,
                "Price of Spray Paint"
                );
        }
    }
    [BepInPlugin(modGUID, modName, modVersion)]
    public class FreeBasicItemsBase : BaseUnityPlugin
    {
        private const string modGUID = "Captland.FreeBasicItems";
        private const string modName = "Captland's Free Basic Items";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static FreeBasicItemsBase Instance;

        public int test = 0;

        public static Config MyConfig { get; internal set; }

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            Config MyConfig = new Config(base.Config);

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo(modName + " is loaded!");

            harmony.PatchAll(typeof(FreeBasicItemsBase));
            harmony.PatchAll(typeof(TerminalPatch));
        }
    }
}

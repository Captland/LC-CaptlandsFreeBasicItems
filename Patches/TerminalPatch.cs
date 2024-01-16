using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptlandFreeBasicItems.Patches
{
    [HarmonyPatch(typeof(Terminal))]
    internal class TerminalPatch
    {
        [HarmonyPatch("SetItemSales")]
        [HarmonyPostfix]
        static void patchStorePrices(ref Item[] ___buyableItemsList)
        {
            ___buyableItemsList[0].creditsWorth = Config.configWalkieTalkiePrice.Value;
            ___buyableItemsList[1].creditsWorth = Config.configFlashlightPrice.Value;
            ___buyableItemsList[2].creditsWorth = Config.configShovelPrice.Value;
            ___buyableItemsList[3].creditsWorth = Config.configLockpickerPrice.Value;
            ___buyableItemsList[4].creditsWorth = Config.configProFlashlightPrice.Value;
            ___buyableItemsList[5].creditsWorth = Config.configStunGrenadePrice.Value;
            ___buyableItemsList[6].creditsWorth = Config.configBoomboxPrice.Value;
            ___buyableItemsList[7].creditsWorth = Config.configInhalantPrice.Value;
            ___buyableItemsList[8].creditsWorth = Config.configZapGunPrice.Value;
            ___buyableItemsList[9].creditsWorth = Config.configJetpackPrice.Value;
            ___buyableItemsList[10].creditsWorth = Config.configExtensionLadderPrice.Value;
            ___buyableItemsList[11].creditsWorth = Config.configRadarBoosterPrice.Value;
            ___buyableItemsList[12].creditsWorth = Config.configSprayPaintPrice.Value;
        }

    }
}

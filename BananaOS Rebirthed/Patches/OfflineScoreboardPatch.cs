using GorillaNetworking;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BananaOS_Rebirthed.Patches
{

    [HarmonyPatch(typeof(GorillaComputer))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    internal class OfflineScoreboardPatch
    {
        private static void Postfix(GorillaComputer __instance)
        {
            __instance.offlineScoreboard.text = "No Monkeys Here \n Right Now \n Because \n You are not \n conencted to a room";
            __instance.offlineScoreboard.color = UnityEngine.Color.yellow;



        }
    }
}

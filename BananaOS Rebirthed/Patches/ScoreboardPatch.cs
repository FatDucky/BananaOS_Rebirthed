using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BananaOS_Rebirthed.Patches
{
    [HarmonyPatch(typeof(GorillaScoreBoard))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    internal class ScoreboardPatch
    {
        private static void Postfix(GorillaScoreBoard __instance)
        {



            





        }
    }
}

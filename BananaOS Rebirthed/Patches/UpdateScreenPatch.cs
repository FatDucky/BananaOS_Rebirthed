using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;

namespace BananaOS_Rebirthed.Patches
{
    [HarmonyPatch(typeof(GorillaComputer))]
    [HarmonyPatch("UpdateScreen", MethodType.Normal)]
    internal class UpdateScreenPatch
    {
        internal static void Postfix(GorillaComputer __instance)
        {
            if (PhotonNetworkController.Instance != null && !PhotonNetworkController.Instance.wrongVersion)
            {
                
                if (__instance.currentState == GorillaComputer.ComputerState.Startup)
                {
                    int usersBanned = Traverse.Create(__instance).Field("usersBanned").GetValue<int>();
                    var name = PhotonNetwork.NickName.ToString();
                    __instance.screenText.text = "BANANA OS\n\n" + "CURRENT NAME : " + name + "\n QOUTE OF THE DAY:" + "BABYS ARE LIKE BALLS YOU THROW THEM WHEN YOU GET ANGRY\n\n" + usersBanned + " USERS BANNED YESTERDAY\n\nPRESS ANY KEY TO CONTINUE\n\n CREDITS TO DEV. FOR COMPUTER PATCH";
                    
                    __instance.wallScreenText.text = "JUMP ON IN MONKE,\n MAKE SOME NEW MONKEY FRIENDS!";
                    
                    __instance.screenText.color = UnityEngine.Color.yellow;
                    
                    __instance.pressedMaterial.color = UnityEngine.Color.yellow;
                    
                    
                }


                if (__instance.currentState == GorillaComputer.ComputerState.Name)
                {
                    
                    var name = PhotonNetwork.NickName;
                    __instance.screenText.text = "BANANA OS \n \nCHANGE YOUR NAME WITH ENTER.\r\n\r\n                    CURRENT NAME: " + name  +  " \r\n\r\n NEW NAME: ";


                }

                if (__instance.currentState == GorillaComputer.ComputerState.Group)
                {
                    Console.WriteLine(__instance.screenText.text);

                    



                    


                }


            }
        }
    }
}

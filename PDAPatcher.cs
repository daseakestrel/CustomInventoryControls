using BepInEx.Logging;
using CustomInventoryInput;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomInventoryInputs;

[HarmonyPatch(typeof(PDA))]
public class PDAPatcher
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(PDA.ManagedUpdate))]
    public static bool ManagedUpdate_Prefix(PDA __instance)
    {
        if (__instance.isFocused && GameInput.GetButtonDown(GameInput.Button.UIMenu))
        {
            __instance.Close();
            return false;
        }
        return true;
    }
}

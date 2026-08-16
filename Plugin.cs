using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInventoryInput;

[BepInPlugin("fr.dasea.custominventoryinput", "Custom Inventory Inputs", "1.0.0.0")]
public class Plugin : BaseUnityPlugin
{

    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {"fr.dasea.custominventoryinput"} is loaded!");
        
        var harmony = new Harmony("fr.dasea.custominventoryinput");
        harmony.PatchAll();
    }
}
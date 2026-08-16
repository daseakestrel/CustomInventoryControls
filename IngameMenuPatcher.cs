using HarmonyLib;

namespace CustomInventoryInputs;

[HarmonyPatch(typeof(IngameMenu))]
public class IngameMenuPatcher
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(IngameMenu.Open))]
    public static bool Open_Prefix()
    {
        if (Player.main.GetPDA().isInUse)
            return false;
        return true;
    }
}

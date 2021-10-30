using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace The1nk.PAP
{
    [HarmonyPatch(typeof(Pawn), "CheckAcceptArrest")]
    class Patch
    {
        static void Postfix(ref Pawn __instance, ref bool __result)
        {
            if (!__result)
                // Pawn wasn't arrested!
                return;

            if (__instance.apparel != null && __instance.apparel.LockedApparel != null)
                for (int index = __instance.apparel.LockedApparel.Count - 1; index >= 0; --index)
                    __instance.apparel.Unlock(__instance.apparel.LockedApparel[index]);
        }
    }
}
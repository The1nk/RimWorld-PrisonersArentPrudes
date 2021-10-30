using HarmonyLib;
using HugsLib;

namespace The1nk.PAP
{
    public class Mod : ModBase
    {
        public override string ModIdentifier => "com.the1nk.pap";

        public Mod()
        {
                // var harmony = new Harmony("com.the1nk.pap");
                // Harmony.DEBUG = true;
                //
                // FileLog.LogBuffered("Pre-Patching");
                // harmony.PatchAll();
                // FileLog.LogBuffered("Post-Patching");
                // FileLog.FlushBuffer();
        }
    }
}
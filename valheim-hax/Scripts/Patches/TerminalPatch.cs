using HarmonyLib;

namespace Hax;

[HarmonyPatch(typeof(Terminal), nameof(Terminal.TryRunCommand))]
public static class TerminalPatch {
    static bool Prefix(ref bool skipAllowedCheck) {
        skipAllowedCheck = true;
        return true;
    }
}

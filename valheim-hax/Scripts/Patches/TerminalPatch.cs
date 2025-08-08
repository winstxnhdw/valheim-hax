using HarmonyLib;

[HarmonyPatch(typeof(Terminal), nameof(Terminal.TryRunCommand))]
sealed class TerminalPatch {
    static bool Prefix(ref bool skipAllowedCheck) {
        skipAllowedCheck = true;
        return true;
    }
}

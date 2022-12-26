namespace Hax;
public class Hax : HaxComponents {
    public static bool HaxPaused { get; private set; } = false;

    void Awake() {
        InputListener.onPausePress += this.ToggleHaxPause;
    }

    void Update() {
        if (Hax.HaxPaused || HaxObjects.LocalPlayerObject == null) {
            Global.SetActiveGameObject(Loader.HaxModules, false);
            return;
        }

        Global.SetActiveGameObject(Loader.HaxModules, true);
    }

    void ToggleHaxPause() {
        Hax.HaxPaused = !Hax.HaxPaused;
        Console.Print($"Hax {(Hax.HaxPaused ? "paused" : "unpaused")}.");
    }

    void OnDestroy() {
        InputListener.onPausePress -= this.ToggleHaxPause;
    }
}

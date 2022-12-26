
using UnityEngine;

namespace Hax;
public class CursorController : HaxComponents {
    bool CursorLocked { get; set; } = false;

    void Update() {
        this.UpdateCursorState();
    }

    void UpdateCursorState() {
        if (ConsoleSettings.ShowConsole) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            this.CursorLocked = false;
        }

        else if (!this.CursorLocked) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            this.CursorLocked = true;
        }
    }
}
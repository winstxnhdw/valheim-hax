using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hax;
public class InputListener : HaxComponents {
    public static event Action onPausePress;
    public static event Action onEscapePress;

    Dictionary<Func<bool>, Action> keyActionsDict = new Dictionary<Func<bool>, Action>() {
        {() => Input.GetKeyDown(KeyCode.Pause),       () => InputListener.onPausePress?.Invoke()},
        {() => Input.GetKeyDown(KeyCode.Escape),      () => InputListener.onEscapePress?.Invoke()}
    };

    void Update() {
        this.KeyboardListener();
    }

    void KeyboardListener() {
        foreach (KeyValuePair<Func<bool>, Action> keyAction in this.keyActionsDict) {
            if (!keyAction.Key()) continue;
            keyAction.Value();
        }
    }
}

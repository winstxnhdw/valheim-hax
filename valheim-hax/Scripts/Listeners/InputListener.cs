using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hax;
public class InputListener : HaxComponents {
    Dictionary<Func<bool>, Action> keyActionsDict = new Dictionary<Func<bool>, Action>() {
        {() => Input.GetKeyDown(KeyCode.BackQuote),   () => Console.ShowConsole()},
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

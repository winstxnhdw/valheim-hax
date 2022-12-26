using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hax;
public static class Global {
    static Camera camera = Camera.main;

    public static Camera Camera {
        get {
            if (!Global.camera) Global.camera = Camera.main;
            return Global.camera;
        }
    }

    public static void SetActiveGameObject(GameObject go, bool isActive) {
        if (go.activeSelf == isActive) return;
        go.SetActive(isActive);
    }
}
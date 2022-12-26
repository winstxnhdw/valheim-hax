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

    public static void PrintInChat(object log) {
        string strLog = log.ToString();

        if (strLog.Contains("\n")) {
            PrintInChat(strLog.Split(Environment.NewLine.ToCharArray()));
            return;
        }

        ChatManager.LocalDebugChatMessage(strLog);
    }

    public static void PrintInChat(IList<string> logs) => new List<string>(logs).ForEach(PrintInChat);

    public static void PrintInChat(IList<int> logs) => PrintInChat(new List<int>(logs).ConvertAll(x => x.ToString()));

    public static void PrintInChat(IList<float> logs) => PrintInChat(new List<float>(logs).ConvertAll(x => x.ToString()));

    public static void PrintInChat(IList<bool> logs) => PrintInChat(new List<bool>(logs).ConvertAll(x => x.ToString()));
}
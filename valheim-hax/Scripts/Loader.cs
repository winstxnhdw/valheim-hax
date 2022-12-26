using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using HarmonyLib;

namespace Hax;
public class Loader : MonoBehaviour {
    static GameObject HaxGameObject { get; } = new GameObject();
    public static GameObject HaxModules { get; } = new GameObject();

    static void AddHaxModules<T>() where T : Component => Loader.HaxModules.AddComponent<T>();
    static void AddHaxGameObject<T>() where T : Component => Loader.HaxGameObject.AddComponent<T>();

    static Assembly OnResolveAssembly(object _, ResolveEventArgs args) {
        Assembly assembly = Assembly.GetExecutingAssembly();

        using Stream stream = assembly.GetManifestResourceStream(
            assembly.GetManifestResourceNames()
                    .First(name => name.EndsWith($"{new AssemblyName(args.Name).Name}.dll"))
        );

        byte[] block = new byte[stream.Length];
        stream.Read(block, 0, block.Length);
        return Assembly.Load(block);
    }

    public static void Load() {
        // AppDomain.CurrentDomain.AssemblyResolve += Loader.OnResolveAssembly;

        // Loader.LoadHarmonyPatches();
        // Loader.LoadHaxGameObjects();
        // Loader.LoadHaxModules();

        // AppDomain.CurrentDomain.AssemblyResolve -= Loader.OnResolveAssembly;
    }

    static void LoadHaxGameObjects() {
        DontDestroyOnLoad(Loader.HaxGameObject);

        AddHaxGameObject<InputListener>();
        AddHaxGameObject<Hax>();
        AddHaxGameObject<HaxObjects>();
    }

    static void LoadHarmonyPatches() {
        new Harmony("winstxnhdw.rc15-hax").PatchAll();
    }

    static void LoadHaxModules() {
        DontDestroyOnLoad(Loader.HaxModules);

    }

    public static void Unload() {
        Destroy(Loader.HaxModules);
        Destroy(Loader.HaxGameObject);
    }
}

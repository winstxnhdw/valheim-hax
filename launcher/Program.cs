using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

Console.WriteLine("Waiting for Valheim to launch...");
Process? process;

while ((process = Process.GetProcessesByName("valheim").SingleOrDefault()) is null) {
    Thread.Sleep(1000);
}

using Process game = process;
_ = game.WaitForInputIdle();
using Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("Launcher.Payload.valheim-hax.dll")
    ?? throw new InvalidOperationException("The launcher does not contain valheim-hax.dll. Rebuild the launcher.");
byte[] payload = new byte[resource.Length];
resource.ReadExactly(payload);
Console.WriteLine("Loading valheim-hax...");
MonoInjector.Inject(game, payload);
Console.WriteLine("valheim-hax loaded.");

if (!Console.IsInputRedirected && !Console.IsOutputRedirected) {
    Console.WriteLine("Press any key to close.");
    _ = Console.ReadKey(intercept: true);
}

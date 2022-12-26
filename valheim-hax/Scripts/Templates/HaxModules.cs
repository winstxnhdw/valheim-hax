namespace Hax;
public class HaxModules : HaxComponents {
    protected virtual bool ModEnabled => true;
    protected bool DefaultStored { get; set; } = false;

    protected virtual void OnEnable() {
        if (!this.ModEnabled) return;
        Console.Print($"{this.GetType().Name} component enabled.");
    }

    protected virtual void OnDisable() {
        if (!this.ModEnabled) return;
        Console.Print($"{this.GetType().Name} component disabled.");
    }
}
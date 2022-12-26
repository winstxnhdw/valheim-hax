using UnityEngine;

namespace Hax;
public class HaxComponents : MonoBehaviour {
    protected virtual void Start() {
        Console.instance.Print($"{this.GetType().Name} started.");
    }
}
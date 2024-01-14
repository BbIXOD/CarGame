using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SlowOnImpact : MonoBehaviour
{
    //TODO: refactor these 3 classes
    [SerializeField]private float slow;
    [SerializeField]private int duration;
    private void OnTriggerEnter2D(Collider2D collision) {
        var isCar = collision.TryGetComponent<CarParams>(out var car);
        if (!isCar) return;
        car.topSpeed -= slow;
        Task.Delay(duration).ContinueWith(_ => car.topSpeed += slow);
    }
}

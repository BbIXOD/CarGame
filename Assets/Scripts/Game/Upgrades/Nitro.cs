using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitro : MonoBehaviour
{
    [SerializeField]private float addSpeed, addAccel;
    [SerializeField]private CarParams _params;
    private void OnEnable() {
        _params.topSpeed += addSpeed;
        _params.acceleration += addAccel;
    }

    private void OnDisable() {
        _params.topSpeed -= addSpeed;
        _params.acceleration -= addAccel;
    }
}

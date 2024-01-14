using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarParams), typeof(Rigidbody2D))]
public class CarSteer : MonoBehaviour
{
    [SerializeField]private PressesToDir amount;
    private Rigidbody2D _rb;
    private CarParams _params;

    private void Awake() {
        _params = GetComponent<CarParams>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        var velocity = _rb.velocity;

        if (amount.dir != 0) {
            velocity.x += amount.dir * _params.turnAcceleration * Time.fixedDeltaTime;
            velocity.x = Mathf.Clamp(velocity.x, -_params.turnSpeed, _params.turnSpeed);
        }
        else {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, _params.turnAcceleration * Time.fixedDeltaTime);
        }

        _rb.velocity = velocity;
    }
}

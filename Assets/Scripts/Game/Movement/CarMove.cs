using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarParams), typeof(Rigidbody2D))]
public class CarMove : MonoBehaviour
{
    [SerializeField]private PressChecker accel, breaks;
    private CarParams _params;
    private Rigidbody2D _rb;

    private void Awake() {
        _params = GetComponent<CarParams>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        var velocity = _rb.velocity;
        
        if (breaks.Pressed) {
            velocity.y -= _params.deceleration * Time.fixedDeltaTime;
        }
        else if (accel.Pressed) {
            velocity.y += _params.acceleration * Time.fixedDeltaTime;
        }
        else {
            velocity.y -= _params.decelerationPassive * Time.fixedDeltaTime;
        }

        velocity.y = Mathf.Clamp(velocity.y, 0, _params.topSpeed);
        _rb.velocity = velocity;
        _params.currentSpeed = _rb.velocity.y;
    }


}

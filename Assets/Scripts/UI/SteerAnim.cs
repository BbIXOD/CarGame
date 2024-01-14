using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerAnim : MonoBehaviour
{
    [SerializeField]private PressesToDir dir;
    [SerializeField]private float maxAngle = 45, speed = 1;
    [SerializeField]private bool reverse = false;

    private void Awake() {
        maxAngle = reverse ? -maxAngle : maxAngle;
    }

    private void Update() {
        transform.rotation =
            Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, maxAngle * dir.dir), Time.deltaTime * speed);
    }
}

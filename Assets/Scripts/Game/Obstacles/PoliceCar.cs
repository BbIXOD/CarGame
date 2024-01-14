using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PoliceCar : MonoBehaviour
{
    [SerializeField]private float offset;

    private void Start() {
        var speed = GoContainer.Instance.player.GetComponent<CarParams>().currentSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed + offset);
    }


}

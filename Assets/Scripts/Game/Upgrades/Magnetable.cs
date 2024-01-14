using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class Magnetable : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D _rb;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (!other.CompareTag(Tags.Magnet)) return;
        _rb.velocity = (other.transform.position - transform.position) * speed;
    }
}

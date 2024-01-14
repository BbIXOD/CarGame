using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class Consumable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (!other.CompareTag(Tags.Player)) return;
        Action();
    }

    protected virtual void Action() {
        Destroy(gameObject);
    }
}

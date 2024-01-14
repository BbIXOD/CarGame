using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnShield : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (!collision.gameObject.CompareTag(Tags.Shield)) return;
        Destroy(gameObject);
    }
}

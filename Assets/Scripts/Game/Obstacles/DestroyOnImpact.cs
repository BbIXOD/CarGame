using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (!collision.gameObject.CompareTag(Tags.Player)) return;
        PlayerHealth.instance.Value = 0;
    }
}

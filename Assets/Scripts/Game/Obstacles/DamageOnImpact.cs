using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnImpact : MonoBehaviour
{
    [SerializeField]private int damage;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.CompareTag(Tags.Player)) return;
        PlayerHealth.instance.Value -= damage;
    }
}

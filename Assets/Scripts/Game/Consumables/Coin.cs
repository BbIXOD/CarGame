using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{

    [SerializeField]private int coinValue;

    private void OnTriggerEnter2D(Collider2D other) {
        if (!other.CompareTag(Tags.Player)) return;
        ScoreManager.coins.AddScore(coinValue);
    }
}

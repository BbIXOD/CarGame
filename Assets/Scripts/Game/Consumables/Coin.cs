using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Consumable
{

    [SerializeField]private int coinValue;

    protected override void Action() {
        ScoreManager.coins.AddScore(coinValue);
        base.Action();
    }
}

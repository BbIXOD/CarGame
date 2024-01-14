using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : Consumable
{
    protected override void Action() {
        PlayerHealth.instance.Value = PlayerHealth.instance.maxHealth;
        base.Action();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Booster : Consumable
{
    [SerializeField]private Boosters type;
    [SerializeField]private int duration;

    private static Booster last;
    private bool turnedWithForce;
    private GameObject booster;

    protected override void Action() {
        last?.TurnOffForce();
        last = this;
        booster = BoostersContainer.instance.boosters.First(x => x.type == type).obj;
        booster.SetActive(true);
        TurnOffWithTimer();
        BoosterShow.instance.Show(type, duration);
        base.Action();
    }

    private async void TurnOffWithTimer() {
        await Task.Delay(duration);
        if (turnedWithForce) return;
        TurnOff();
    }

    public void TurnOffForce() {
        turnedWithForce = true;
        TurnOff();
    }

    private void TurnOff() {
        if (booster == null) return;
        booster.SetActive(false);
    }
}

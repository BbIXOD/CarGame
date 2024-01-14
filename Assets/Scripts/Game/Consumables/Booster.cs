using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Booster : Consumable
{
    [SerializeField]private Boosters type;
    [SerializeField]private float duration;

    private static Booster last;
    private bool turnedWithForce;
    private GameObject booster;

    protected override void Action() {
        last?.TurnOffForce();
        last = this;
        booster = BoostersContainer.instance.boosters.First(x => x.type == type).obj;
        booster.SetActive(true);
        GoContainer.Instance.StartCoroutine(TurnOffWithTimer()); // possible bug if remove goContainer
        BoosterShow.instance.Show(type, duration);
        base.Action();
    }

    private IEnumerator TurnOffWithTimer() {
        yield return new WaitForSeconds(duration);
        if (turnedWithForce) yield break;
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

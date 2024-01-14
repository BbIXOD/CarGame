using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField]private BarLengthController _healthBar;
    [SerializeField]private GameObject _deathScreen;

    [NonSerialized]public static Health instance;

    protected override void Awake() {
        base.Awake();
        instance = this;
    }

    protected override void OnHealthChanged(int value) {
        _healthBar.BarLength = value / (float)maxHealth;
    }

    protected override void OnDeath() {
        _deathScreen.SetActive(true);
        SetFinalScore.Instance.Set();
        Time.timeScale = 0;
    }
}

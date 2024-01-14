using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//should i use interface here?
public class Health : MonoBehaviour
{
    public int maxHealth;
    private int _health;

    public int Value { get => _health; set => SetHealth(value); }

    protected virtual void Awake() {
        _health = maxHealth;
    }

    private void SetHealth(int value) {
        _health = value;
        OnHealthChanged(_health);

        if (_health > 0) return;

        OnDeath();
    }

    protected virtual void OnHealthChanged(int value) {}
    protected virtual void OnDeath() {}
}

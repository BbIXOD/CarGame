using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarDecreaser : MonoBehaviour
{
    [SerializeField]private BarLengthController bar;
    [SerializeField]private GameObject _barObj;
    private float _speed, _current;

    public void StartDecreasing(float speed) {
        _speed = speed;
        _current = 1;
        _barObj.SetActive(true);
    }

    private void Update() {
        if (_current <= 0) return;

        _current -= Time.deltaTime * _speed;
        bar.BarLength = _current;

        if (_current > 0) return;
        _barObj.SetActive(false);
    }
}

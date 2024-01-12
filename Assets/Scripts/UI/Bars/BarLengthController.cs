using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarLengthController : MonoBehaviour
{
    public RectTransform bar;
    private float barMaxLength;
    [Range(0, 1)]private float barLength;
    public float BarLength { set => SetBarLength(value); }

    private void Start() {
        bar = bar != null ? bar : GetComponent<RectTransform>();
        barMaxLength = bar.rect.width;
    }

    private void SetBarLength(float length) {
        barLength = length;
        bar.sizeDelta = new Vector2(barLength * barMaxLength, bar.rect.height);
    }
}

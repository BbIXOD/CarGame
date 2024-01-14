using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarLengthController : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 4;
    public RectTransform bar;
    private float barMaxLength;
    [Range(0, 1)]private float barLength, currentLength = 1;
    public float BarLength { set => barLength = value; } // why is it here?

    private void Start() {
        bar = bar != null ? bar : GetComponent<RectTransform>();
        barMaxLength = bar.rect.width;
    }

    private void Update() {
        if (currentLength == barLength) return;
        currentLength = Mathf.Lerp(currentLength, barLength, Time.deltaTime * moveSpeed);
        bar.sizeDelta = new Vector2(currentLength * barMaxLength, bar.rect.height);
    }
}

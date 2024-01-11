using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressesToDir : MonoBehaviour
{
    [SerializeField]private PressChecker positive, negative;

    [NonSerialized]public int dir;

    private void Update() {
        dir = Convert.ToInt16(positive.Pressed) - Convert.ToInt16(negative.Pressed);
    }
}

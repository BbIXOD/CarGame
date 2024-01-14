using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberToTMP : MonoBehaviour
{
    public TMP_Text text;
    public string format = "N";
    private int _number = 0;
    public int Number { set => SetNumber(value); }

    private void Start() {
        text = text != null ? text : GetComponent<TMP_Text>();
    }

    private void SetNumber(int number) {
        _number = number;
        text.text = PrepareNumber(_number);
    }

    protected virtual string PrepareNumber(int number) {
        return number.ToString(format);
    }
}

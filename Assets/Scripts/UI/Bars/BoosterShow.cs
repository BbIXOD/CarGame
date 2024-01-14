using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System.Threading.Tasks;

public class BoosterShow : MonoBehaviour
{
    [SerializeField]private Sprite[] lineColors;
    [SerializeField]private BarDecreaser decreaser;
    [SerializeField]private Image bar;
    [SerializeField]private TMP_Text caption;

    private const float MilisecondsPerSecond = 1000f;

    public static BoosterShow instance;

    private void Awake() {
        instance = this;
    }

    public void Show(Boosters type, int duration) {
        bar.sprite = lineColors[(int)type];
        caption.text = type.ToString();
        decreaser.StartDecreasing(MilisecondsPerSecond / duration);
    }
}

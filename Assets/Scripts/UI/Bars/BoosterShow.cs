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

    public static BoosterShow instance;

    private void Awake() {
        instance = this;
    }

    public void Show(Boosters type, float duration) {
        bar.sprite = lineColors[(int)type];
        caption.text = type.ToString();
        decreaser.StartDecreasing(1 / duration);
    }
}

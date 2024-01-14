using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTime : MonoBehaviour
{
    [SerializeField]private float time;

    public void Scale() {
        Time.timeScale = time;
    }
}

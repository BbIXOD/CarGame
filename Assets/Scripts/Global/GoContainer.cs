using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoContainer : MonoBehaviour
{
    public static GoContainer Instance {get; private set;}

    public GameObject player;

    private void Awake() {
        Instance = this;
    }

    private void OnDestroy() {
        Instance = null;
    }
}

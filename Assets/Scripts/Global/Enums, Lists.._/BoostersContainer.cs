using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostersContainer : MonoBehaviour
{
    public BoosterObject[] boosters;
    public static BoostersContainer instance;

    private void Awake() {
        instance = this;
    }


}

[Serializable]
public class BoosterObject {
    public Boosters type;
    public GameObject obj;
}

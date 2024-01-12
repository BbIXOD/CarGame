using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActiveState : MonoBehaviour
{
    public GameObject target;

    public void Change() {
        target.SetActive(!target.activeSelf);
    }
}

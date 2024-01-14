using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private float delayInSeconds;
    [SerializeField]private GameObject prefab;

    private IEnumerator Start() {
        while (true) {
            yield return new WaitForSeconds(delayInSeconds);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}

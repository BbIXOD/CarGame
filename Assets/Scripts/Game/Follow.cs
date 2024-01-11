using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target, follower;
    public float speed;
    public Vector3 offset;

    private void Update() {
        follower.position = Vector3.Lerp(follower.position, target.position + offset, Time.deltaTime * speed);
    }
}

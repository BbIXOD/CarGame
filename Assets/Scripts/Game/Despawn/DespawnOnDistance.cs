using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnOnDistance : MonoBehaviour
{
    [SerializeField] private float distance;
    private Transform _player;

    private void Start() {
        _player = GoContainer.Instance.player.transform;
    }

    private void FixedUpdate() {
        if (Vector2.Distance(_player.position, transform.position) > distance) {
            Destroy(gameObject);
        }
    }
}

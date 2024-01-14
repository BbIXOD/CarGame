using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]private ScoreHandler score;
    [SerializeField]private Transform observable;
    private Vector3 lastPos;
    private float unAddedScore;

    private void Start() {
        lastPos = observable.position;
        score = ScoreManager.score;
    }

    private void FixedUpdate() {
        unAddedScore += observable.position.y - lastPos.y;
        lastPos = observable.position;

        if (unAddedScore < 1) return;
        score.AddScore(1);
        unAddedScore--;
    }
}

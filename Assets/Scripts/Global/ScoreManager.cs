using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreHandler score, coins;
    [SerializeField] private NumberToTMP scoreField, coinField;

    private void Awake() {
        score = new ScoreHandler(scoreField);
        coins = new ScoreHandler(coinField);
    }
}

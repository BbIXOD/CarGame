using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBest : MonoBehaviour
{
    public int bestScore, bestCoins;

    public const string
        BestScore = nameof(BestScore),
        BestCoins = nameof(BestCoins);

    private void Awake() {
        bestScore = PlayerPrefs.GetInt(BestScore, 0);
        bestCoins = PlayerPrefs.GetInt(BestCoins, 0);
    }

    private void OnDestroy() {
        PlayerPrefs.SetInt(BestScore, bestScore);
        PlayerPrefs.SetInt(BestCoins, bestCoins);
    }
}

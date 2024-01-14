using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFinalScore : MonoBehaviour
{
    [SerializeField]private NumberToTMP currentScore, bestScore, currentCoins, bestCoins;
    [SerializeField]private SaveBest best;

    public static SetFinalScore Instance { get; private set; }

    private void Awake() {
        Instance = this;
    }

    public void Set() {
        best.bestScore = Mathf.Max(best.bestScore, ScoreManager.score.Score);
        best.bestCoins = Mathf.Max(best.bestCoins, ScoreManager.coins.Score);

        currentScore.Number = ScoreManager.score.Score;
        bestScore.Number = best.bestScore;
        bestCoins.Number = best.bestCoins;
        currentCoins.Number = ScoreManager.coins.Score;
    }
}

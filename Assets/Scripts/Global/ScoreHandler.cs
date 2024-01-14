using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler
{
    private readonly NumberToTMP _scoreField;
    private int score = 0;

    public ScoreHandler(NumberToTMP scoreField) {
        _scoreField = scoreField;
    }

    public void AddScore(int value) {
        score += value;
        _scoreField.Number = score;
    }

}

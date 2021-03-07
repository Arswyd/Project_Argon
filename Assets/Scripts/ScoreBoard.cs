﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        DisplayScore();
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        DisplayScore();
    }

    void DisplayScore()
    {
        scoreText.text = score.ToString();
    }
}

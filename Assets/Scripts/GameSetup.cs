﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSetup : MonoBehaviour
{

    public int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}

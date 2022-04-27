using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreCalcule : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int scoreNb;
    public GameObject win;
    public GameObject lose;
    public AudioSource winSound;
    public AudioSource loseSound;

    public void Incriment()
    {
        scoreNb = Int32.Parse(score.text);
        scoreNb++;
        score.text = scoreNb.ToString();
        if(scoreNb==2)
        {
            win.SetActive(true);Debug.Log("You won");winSound.Play(0);
        }
    }
    public void Decriment()
    {
        lose.SetActive(true);Debug.Log("You lost");loseSound.Play(0);
    }
}

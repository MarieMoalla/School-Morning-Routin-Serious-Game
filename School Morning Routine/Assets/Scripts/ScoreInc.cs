using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreInc : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int scoreNb;

    public void Incriment()
    {
        scoreNb = Int32.Parse(score.text);
        scoreNb++;
        score.text = scoreNb.ToString();
    }
    public void Decriment()
    {
        scoreNb = Int32.Parse(score.text);
        scoreNb--;
        score.text = scoreNb.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetScoreValue : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI thisText;
    // Update is called once per frame
    void Update()
    {
        thisText.text = score.text;
    }
}

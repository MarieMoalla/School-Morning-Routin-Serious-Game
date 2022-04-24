using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System;

public class DropBox : MonoBehaviour, IDropHandler
{
    //score variables
    public TextMeshProUGUI scoreText;
    private int score;
    //win lost variables
    public Text nbElement;
    private int nbElementToInt;
    public int elementsNumber;
    public GameObject win;
    public GameObject lose;
    public AudioSource winSound;
    public AudioSource loseSound;

    public void OnDrop (PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        score = Int32.Parse(scoreText.text);
        nbElementToInt = Int32.Parse(nbElement.text);
        LostWin(elementsNumber);
        //score color settings
        if(score<0) scoreText.color = Color.yellow;
        else scoreText.color = Color.white;

        if(eventData.pointerDrag != null) 
        {
            // score Incriment/decriment
            if (eventData.pointerDrag.tag == gameObject.tag) 
            {
                score++;
                scoreText.text = score.ToString();
                //play audio good
            }
            else
            {
                score--;
                scoreText.text = score.ToString();
                //play audio bad
            }
            //distroy collected element
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.SetActive(false);
            
        }
        
    }
    public void LostWin (int element)
    {
        nbElementToInt = nbElementToInt+1;
        nbElement.text = nbElementToInt.ToString();
        Debug.Log(nbElementToInt+"elements collecte!");
        //if level ends
        if(nbElementToInt == element) 
        {
            if(score >=5) {win.SetActive(true);Debug.Log("You won");winSound.Play(0);}
            else {lose.SetActive(true);Debug.Log("You lost");loseSound.Play(0);}
        }
    }
}

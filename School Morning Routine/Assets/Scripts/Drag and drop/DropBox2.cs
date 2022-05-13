using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System;

public class DropBox2 : MonoBehaviour, IDropHandler
{

    //win lost variables
    public GameObject win;
    public GameObject conceil;
    public AudioSource winSound;
    public AudioSource loseSound;

    public void OnDrop (PointerEventData eventData)
    {
        
        Debug.Log("OnDrop");
        if(this.tag == "win"){win.SetActive(true);Debug.Log("You won");winSound.Play(0);}
        else {conceil.SetActive(true);Debug.Log("You lost");loseSound.Play(0);}
        
    }
}


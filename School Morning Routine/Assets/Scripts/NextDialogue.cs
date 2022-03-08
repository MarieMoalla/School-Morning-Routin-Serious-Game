using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDialogue : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject currentDialogue;
    public void onOpenDialogue()
    {
        if(dialogue != null)    dialogue.SetActive(true);
        currentDialogue.SetActive(false);
    }
}

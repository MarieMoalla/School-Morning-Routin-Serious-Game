using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAfter : MonoBehaviour
{
    public GameObject obj;
    public int waitFor;

    void Start()
    {
        StartCoroutine(ExecuteActive());
    }

    IEnumerator ExecuteActive() 
    {
        yield return new WaitForSeconds(waitFor);
        obj.SetActive(true);
        Debug.Log("oepn first");
    }
}

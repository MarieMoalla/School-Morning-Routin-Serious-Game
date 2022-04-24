using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    public GameObject obj;
    public int counter;

    public void SetActive() {
        obj.SetActive(true);
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void Desactive() {
        StartCoroutine(Execute());
    }
    IEnumerator Execute() 
{
        yield return new WaitForSeconds(counter);
        obj.SetActive(false);
        Debug.Log("oepn first");
}
}

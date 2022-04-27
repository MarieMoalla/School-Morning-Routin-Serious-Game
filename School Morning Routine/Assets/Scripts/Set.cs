using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    public GameObject obj;
    public int counter;

    public void SetActive() {
        StartCoroutine(ExecuteActive());
    }
        IEnumerator ExecuteActive() 
{
        yield return new WaitForSeconds(counter);
        obj.SetActive(true);
        Debug.Log("oepn first");
}
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void Desactive() {
        StartCoroutine(ExecuteDesacrive());
    }
    IEnumerator ExecuteDesacrive() 
{
        yield return new WaitForSeconds(counter);
        obj.SetActive(false);
        Debug.Log("oepn first");
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    public GameObject obj;

    public void SetActive() {
        obj.SetActive(true);
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowMainView() {
        obj.SetActive(false);
    }
}

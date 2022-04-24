using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaleraSwitch : MonoBehaviour
{
    public Camera MainCamera;
    public Camera overheadCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        MainCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowMainView() {
        StartCoroutine(Activate());
    }

    IEnumerator Activate() 
    {
            yield return new WaitForSeconds(1);
            Debug.Log("switch");
            MainCamera.enabled = true;
            overheadCamera.enabled = false;
    }
}

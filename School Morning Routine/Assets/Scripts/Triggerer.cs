using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Triggerer : MonoBehaviour
{
public GameObject obj;

void Start ()
{
    StartCoroutine(Load());
}

IEnumerator Load() 
{
        yield return new WaitForSeconds(5);
        obj.SetActive(true);
        Debug.Log("oepn first");
}

}

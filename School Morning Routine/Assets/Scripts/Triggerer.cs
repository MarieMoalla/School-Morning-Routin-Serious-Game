using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Triggerer : MonoBehaviour
{
public GameObject obj;

void Start ()
{
    Load();
}

private IEnumerator Load() 
{
        yield return new WaitForSeconds(3);
        obj.SetActive(true);
}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesManager : MonoBehaviour
{

    public CuboScript[] cuboScripts;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cuboScripts.Length; i++) { 

            Debug.Log(cuboScripts[i].esPersistente);
        }
    }

}

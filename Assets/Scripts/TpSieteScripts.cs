using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpSieteScripts : MonoBehaviour
{
    public int[] edades = { 80, 81, 57, 49, 18, 21 };
    // Start is called before the first frame update
    void Start()
    {
        //Escribir el primer elemento del array
        Debug.Log("Primer Elemento: " + edades[0]);

        //Escribir la cantidad de elementos del array
        Debug.Log("La cantidad de elementos: " + edades.Length);

        //Escribir cada elemento del array
        Debug.Log("Todos los elementos: ");
        for(int i = 0; i < edades.Length; i++)
        {
            Debug.Log("Elemento: " + i + " es: " + edades[i]);
        }

        //Escribir el promedio de los elementos del array
        int total = 0;
        for (int i = 0; i < edades.Length; i++)
        {
            total += edades[i];
        }
        Debug.Log("Promedio: " + total / edades.Length);
        //Escribir los elementos del array mayores que 20

        for (int i = 0; i < edades.Length; i++)
        {
            if(edades[i] > 20)
            {
                Debug.Log(edades[i]);
            }
        }

        //Escribir los elementos del array en orden inverso
        for (int i = 0; i < edades.Length; i++)
        {
            Debug.Log("Elemento: " + i + " es: " + edades[edades.Length - i - 1]);
        }
    }
}

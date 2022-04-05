using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    // Start is called before the first frame update

    public int num1;
    public int num2;

    void Start()
    {

        int res;
        res = num1 / num2;
        if (num2 == 0)
        {

            Debug.Log("No se puede dividir por cero");

        }
        else
        {
            Debug.Log("El resultado de la division entre " + num1 + "y " + num2 + "Es igual a " + res);
        }
    }






    // Update is called once per frame
    void Update()
    {

    }

}
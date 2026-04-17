using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cálculos : MonoBehaviour
{
    public int Num1;
    public int Num2;
    // Start is called before the first frame update
    void Start()
    {
        int Resultado = Num1 + Num2;
        Debug.Log("El resultado es igual a " + Resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeBariables : MonoBehaviour
{
    public int Entero;       
    public float Decimal;
    public string Palabra;
    public bool SiNo;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Entero);
        Debug.Log(Decimal);
        Debug.Log(Palabra);
        Debug.Log(SiNo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

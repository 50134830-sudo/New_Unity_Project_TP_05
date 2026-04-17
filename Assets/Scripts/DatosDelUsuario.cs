using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string Nombre;
    public int Edad;
    public float Estatura;
    public bool EsDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + Nombre + ", tengo " + Edad + " años , mido " + Estatura + " metros y es " + EsDonante + " que soy donante de organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

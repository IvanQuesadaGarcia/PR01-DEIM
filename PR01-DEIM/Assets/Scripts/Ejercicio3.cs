using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    [SerializeField] string nombre = "Iván"; //variable para la parte a del ejercicio 3
    [SerializeField] float num1;
    [SerializeField] float num2;
    private float resultado;

    // Start is called before the first frame update
    void Start()
    {
        Saludar();
        print(Sumar(num1, num2));
    }

    //método para la parte a del ejercicio 3
    void Saludar()
    {
        print("Hola " + nombre);
    }

    //método para la parte b del ejercicio 3
    float Sumar(float num1, float num2)
    {
        float resultado = num1 + num2;
        print(PositivoNegativo(resultado));
        return resultado;
    }

    bool PositivoNegativo(float numero)
    {
        bool resultado;
        if(numero >= 0)
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }
        return resultado;
    }
}

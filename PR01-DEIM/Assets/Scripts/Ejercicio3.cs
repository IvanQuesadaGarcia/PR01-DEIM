using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    [SerializeField] string nombre = "Iván"; //variable para la parte a del ejercicio 3
    [SerializeField] float num1; //variables para el método Sumar
    [SerializeField] float num2;
    [SerializeField] float cifra1; //variables para el método Operación
    [SerializeField] float cifra2;
    [SerializeField] int op;
    private float resultado; 


    // Start is called before the first frame update
    void Start()
    {
        Saludar();
        print(Sumar(num1, num2));
        print(Operacion(cifra1, cifra2, op));
    }


    //método para la parte a del ejercicio 3 (saludar al usuario)
    void Saludar()
    {
        print("Hola " + nombre);
    }


    //métodos para la parte b del ejercicio 3 (hacer una operación e indicar un valor boleano)
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


    //método para hacer diferentes operaciones en base a una variable
    float Operacion(float cifra1, float cifra2, int op)
    {
        float resultado;

        if (op == 0)
        {
            resultado = cifra1 + cifra2;
        }
        else if (op == 1)
        {
            resultado = cifra1 - cifra2;
        }
        else if (op == 2)
        {
            resultado = cifra1 * cifra2;
        }
        else if (op == 3)
        {
            resultado = cifra1 / cifra2;
        }
        else
        {
            resultado = 0f;
        }
        return resultado;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    int n;
    int aleatorio;
    // Start is called before the first frame update
    void Start()
    {
        /*
        //parte b del ejercicio 2 (bucle con while y for)
        while(n < 10)
        {
            n++;
            print(n);
        }
        */

        /*
        //parte c del ejercicio 2 (combinación de bucles)
        for(n = 0; n <= 10; n++)
        {
            print("Contador: " + n);
            if (n >= 10)
            {
                print("El contador es superior a " + n);
            }
        }
        */

        //parte d del ejercicio 2 (generar números al azar)
        while (aleatorio != 9)
        {
            print("No ha salido el 9, es " + aleatorio);
            aleatorio = Random.Range(0, 1690);
        }
        print("¡Ha salido el 9!");
    }
}

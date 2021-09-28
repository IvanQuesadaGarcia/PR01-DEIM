using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    int segundos;
    int minutos;
    int horas;
    string texto;

    // Start is called before the first frame update
    void Start()
    {
        segundos = 0;
        minutos = 0;
        horas = 0;
        StartCoroutine("startReloj");
    }

    IEnumerator startReloj()
    {
        for( ; ; segundos++)
        {
            if(segundos > 59)
            {
                minutos++;
                segundos = 0;
            }
            string segundosSt = segundos.ToString("D2");

            if (minutos > 59)
            {
                horas++;
                minutos = 0;
            }
            string minutosST = minutos.ToString("D2");
            string horasST = horas.ToString();

            texto = horasST + ":" + minutosST + ":" + segundosSt;
            print(texto);
            yield return new WaitForSeconds(1f);
        }
    }
}

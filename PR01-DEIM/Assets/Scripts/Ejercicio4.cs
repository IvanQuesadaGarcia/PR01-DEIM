using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    int n = 0;
    bool encendido = false;
    [SerializeField] Text miContador;

    // Start is called before the first frame update
    void Start()
    {
     
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (encendido == false)
            {
                StartCoroutine("Contador");
                encendido = true;
            }
            else
            {
                StopCoroutine("Contador");
                encendido = false;
            }
        }
    }

    IEnumerator Contador()
    {
        while (true)
        {
            n++;
            miContador.text = n.ToString();
            yield return new WaitForSeconds(1f);

        }
    }
}

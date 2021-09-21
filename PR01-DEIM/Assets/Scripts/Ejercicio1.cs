using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float num1 = 10f;
    [SerializeField] int num2 = 3;
    string contador = "Score: ";

    // Start is called before the first frame update
    void Start()
    {
        print(num1 = 2);
        print(num2 = 9);
        print(contador + num1 * num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    void Update()
    {
        //Con esta l�nea, nuestro objeto tendr� la misma posici�n que el jugador
        transform.position = playerPosition.position;
        //Con esta l�nea, la c�mara mantiene su posici�n en X y Z, pero sigue al jugador en Y
        //�til para juegos de plataformas
        transform.position = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        //Con este c�digo, la c�mara seguir� al jugador, pero alejado algo en el eje Z
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 50, playerPosition.position.z - 200);
        //Con este c�digo, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea m�s brusco ser� el movimiento
        Vector3 targetPosition = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        //Opcional: que la c�mara mire al objeto (la c�mara no puede ser ortogr�fica)
        transform.LookAt(playerPosition);
    }
}

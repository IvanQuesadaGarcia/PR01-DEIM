using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    [SerializeField] Vector3 playerPosition = new Vector3(0f, 0f, 0f);
    public float speed = 300f;
    public float friction = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed * friction);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed * friction);
    }
}

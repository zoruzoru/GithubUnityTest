using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            print("Se está pulsando M.");
        }

        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);

        print(Input.GetAxis("Vertical"));

        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desplX * Time.deltaTime);
    }
}

using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Update()
    {
        Moverse();
        Reiniciar();
    }

    void Reiniciar()
    {
        if (Input.GetKeyUp(KeyCode.Joystick1Button7))
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity; //Quaternion para rotaciones
           print("Reiniciado.");
        }
    }
    void Moverse()
    {
        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);

        print(Input.GetAxis("Vertical"));

        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desplX * Time.deltaTime);

        float desplR = Input.GetAxis("Rotate");
        transform.Rotate(Vector3.up * desplR * 360 * Time.deltaTime);
    }
}

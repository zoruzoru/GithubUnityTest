using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {

        StartCoroutine("Cronometro");//Empezar cronometro
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Cronometro()
    {
        for (int i = 0; i < 100; i++) //para hacerlo infinito eliminar i < 100
        {
            print("Contador: " + i);
            yield return new WaitForSeconds(speed);

            if (Input.GetKeyUp(KeyCode.P)) 
            {
                print("Se ha detenido el cronometro");
                StopCoroutine("Cronometro");
            }

        }
        //while (true) //bucle infinito
        //{
            //print("Hola");
            //yield return new WaitForSeconds(1f); //null cada fotograma //new WaitForSeconds para segundos
        //}
        
    }
}

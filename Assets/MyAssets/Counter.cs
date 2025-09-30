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

    IEnumerator Cronometro() //Enumerator para hacer el cronometro
    {
        for (int i = 0 ; i < 100; i++) //para hacerlo infinito eliminar i < 100 | declarar, si algo pasa, sucede algo
        {
            print("Contador: " + i);
            yield return new WaitForSeconds(1f);

            if (Input.GetKey(KeyCode.P)) //arrglar getkey, buscar otro metodo
            {
                StopCoroutine("Cronometro");
                print("Se ha detenido el cronometro");

            }

        }
        //while (true) //bucle infinito
        //{
            //print("Hola");
            //yield return new WaitForSeconds(1f); //null cada fotograma //new WaitForSeconds para segundos
        //}
        
    }
}

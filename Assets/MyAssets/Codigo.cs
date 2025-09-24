using System.Xml.Linq;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    float shield = 3;
    int lifes = 3;
    bool alive = true;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        {
            Impact();
        }
    }

    void Movement()
    {

    }
    
    void Impact()
    {
        shield--;
        //Indicador de pérdida de escudo
        if (shield == 0)
        {
            print("Has perdido el escudo");
        }
        //Función para restar escudo y vida
        if (shield <= 0)
        {
            lifes--;
            print("Has recibido un impacto, te quedan " + lifes + " vidas restantes.");
        }
        else
        {
            print("Has recibido un impacto, te queda " + shield + " de escudo");
        }
        //Función para terminar la partida
        if (lifes <= 0)
        {
            alive = false;
            print("GAME OVER"); ;
        }

    }
}


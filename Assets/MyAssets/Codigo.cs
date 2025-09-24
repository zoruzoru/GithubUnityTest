using System.Threading;
using System.Xml.Linq;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int shield;
    int lifes;
    bool alive;
    int damage;
    int score;
    float speed;
    float tiempo;
    int segundos;
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        {
            Impact();
        }
        
        if(Input.GetKeyDown(KeyCode.R) == true && alive == true)
        {
            Restart();
        }

        if(Input.GetKeyDown(KeyCode.F) == true && alive == true)
        {
            Healing();
        }
        
        if(Input.GetKeyDown(KeyCode.X)  == true && alive == true)
        {
            Score();
        }

        tiempo += Time.deltaTime;
        if ( tiempo >= 1f)
        {
            segundos++;
            score++;
        }
    }

    void MostrarMensaje(string msg)
    {
        print(msg);
    }
    void StartGame()
    {
             shield = 3;
             lifes = 4;
             alive = true;
             damage = 1;
             score = 0;
    }
    void Healing()
    {
        if (lifes < 3)
        {
            lifes++;
            print("Te has curado 1 de vida, ahora tienes " + lifes + " de vida");
        }
        else
        {
            print("Ya estás al máximo de vida");
        }
    }
    void Restart()
    {
        lifes = 4;
        shield = 3;
        print("Has reseteado la partida, vuelves a tener todas las estadisticas");
    }
    void Impact()
    {
        //codigo feo
        shield -= damage;
        //Función para restar escudo y vida

        if (shield == 0)
        {
            print("Has perdido el escudo, puedes curarte cuando lo necesites con F");
        }

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
            print("GAME OVER, tu puntuación ha sido de "+ score +" puntos.");
        }

    }
    void Score()
    {
        print("Tu puntuacion es de " + score + " puntos.");
    }

}


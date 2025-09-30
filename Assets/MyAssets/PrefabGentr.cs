using UnityEngine;

public class PrefabGen : MonoBehaviour
{
    [SerializeField] GameObject Prefabs;
    [SerializeField] Transform InPos; //Almacenar datos de posicion, rotacion y escala

    Vector3 NewPos;
    void Start()
    {
        for (int n = 0;n < 10; n++)
        {
            Vector3 CambioPos = new Vector3(n, 0, 0); //Declarar la ubicacion del cambio de posicion
            NewPos = InPos.position + CambioPos; //En cada vuelta del bucle for se genera una nueva posicion
            Instantiate(Prefabs, NewPos, Quaternion.identity); //Codigo para generar un prefab
        }

        
    }

}

    //        DestroyObject(Prefabs, NewPos, Quaternion.identity);
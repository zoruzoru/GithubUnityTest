using UnityEngine;

public class Prefab : MonoBehaviour
{
    [SerializeField] float speed = 2f; //valor variable
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);//Movimiento del prefab asignado
    }
}

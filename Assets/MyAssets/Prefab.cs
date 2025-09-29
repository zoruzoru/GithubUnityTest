using UnityEngine;

public class Prefab : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}

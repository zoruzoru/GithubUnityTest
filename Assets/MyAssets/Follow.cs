using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform following;

    int speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Seguir();
    }

    void Seguir()
    {
        Vector3 despl = following.position - transform.position;
        transform.Translate(despl.normalized * Time.deltaTime * speed);
    }

}


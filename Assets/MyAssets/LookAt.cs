using UnityEngine;

public class LookAt : MonoBehaviour
{

    [SerializeField] Transform PointAt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(PointAt);
    }
}

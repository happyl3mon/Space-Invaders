using UnityEditor;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(bullet, 0f);
        Debug.Log("worked");
    }
}

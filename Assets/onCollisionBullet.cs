using System;
using Unity.VisualScripting;
using UnityEngine;

public class onCollisionBullet : MonoBehaviour
{
    public event EventHandler OnCollision;
    public static bool hasCollided;
    [SerializeField] private GameObject EnemySq;
    private float timer = 0f;
    private float maxTime = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasCollided = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            Destroy(this.gameObject);
        }
        timer += Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        hasCollided = true;

        Debug.Log(hasCollided);

        if (!collision.gameObject.IsDestroyed())
        {
            Destroy(collision.gameObject);
        }
        Debug.Log("bullet has destroyed collision target");

        Debug.Log(hasCollided);
    }
}

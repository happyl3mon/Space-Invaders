using System;
using Unity.VisualScripting;
using UnityEngine;

public class onCollisionSqEnemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       onCollisionBullet onCollisionBullet = bullet.GetComponent<onCollisionBullet>();
       onCollisionBullet.OnCollision += onHitEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<onCollisionBullet>().IsDestroyed())
        {
            Destroy(collision.gameObject);
        }
        Debug.Log("object has collided with enemy");
    }

    private void onHitEnemy(object sender, EventArgs e)
    {
        Debug.Log("event fired");
    }
}

using UnityEngine;

public class onCollisionSqEnemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // OnCollisionBullet onCollisionBullet hitRegister = bullet.GetComponent<onCollisionBullet>();
       //onCollisionBullet.OnHit += onHitEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onHitEnemy()
    {
        
    }
}

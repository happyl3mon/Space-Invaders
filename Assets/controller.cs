using System.Collections.Generic;
//using System.Diagnostics;
using JetBrains.Annotations;
using UnityEngine;


public class controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private KeyCode moveLeft;
    [SerializeField] private KeyCode moveRight;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float movementBoundaryX = 7.5f;
    [SerializeField] private float yLimit = 3.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private KeyCode shootBullet;
    public List<GameObject> projectileInstances;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject[] projectileInstances = new GameObject[] {};
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }

        if (movementBoundaryX < transform.position.x)
        {
            // negative yLimit since yLimit is set to positive by default
            // right side
            transform.position = new Vector2(movementBoundaryX, -yLimit);
        }

        if (-movementBoundaryX > transform.position.x)
        {
            // negative yLimit since yLimit is set to positive by default]
            // left side
            transform.position = new Vector2(-movementBoundaryX, -yLimit);
        }

        if (Input.GetKeyDown(shootBullet))
        {
            shootBulletFunc();
        }
    }

    public void shootBulletFunc()
    {
        Vector3 origin = transform.position;
        GameObject bulletInstance = Instantiate(bullet, origin, Quaternion.identity);
        projectileInstances.Add(bulletInstance);
        Debug.Log(projectileInstances.Count);

        bulletInstance.transform.Translate(new Vector3(0f, 1f));
        Destroy(bulletInstance, 5f);
        // does that work? NOPE... still working w chatgpt to brainstorm how to do this
        // chatgpt question reminded me of delegates... so were gonna look at that tut again and implement

        // wth...
        // im trying to think of a way to sense when the particular instance is destroyed and remove the
        // particular instance
    }

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        // this will be needed later for player death, not for initial purpose
    }
}

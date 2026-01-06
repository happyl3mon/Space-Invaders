using UnityEngine;

public class bulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, 1f) * Time.deltaTime * bulletSpeed);
    }
}

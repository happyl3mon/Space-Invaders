using UnityEngine;

public class simpleMovementSq : MonoBehaviour
{
    [SerializeField] private float SqMoveSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, -1f) * Time.deltaTime * SqMoveSpeed);
    }
}

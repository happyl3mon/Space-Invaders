using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class onCollisionBullet : MonoBehaviour
{
    public event EventHandler OnHit;

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
        OnHit?.Invoke(this, EventArgs.Empty);
    }
}

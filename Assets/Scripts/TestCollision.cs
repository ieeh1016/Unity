using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name} !");
    }
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log($"Trigger @ {other.gameObject.name} !" );
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilBehaviour : MonoBehaviour
{
    public int enemyCooldown = 1;
    
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        Debug.Log("Hej, jeg er ond!");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bulletTag"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}

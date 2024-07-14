using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class evilBehaviour : MonoBehaviour
{
    public int enemyCooldown = 1;
    
    // Start is called before the first frame update
    Rigidbody rb;
    private NavMeshAgent Agent;
    private GameObject player;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = player.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bulletTag"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}

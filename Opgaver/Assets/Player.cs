using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    Rigidbody rb;
    public int player_speed = 5;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jeg er god!");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = rb.velocity;
        movement.x = Input.GetAxisRaw("Horizontal") * player_speed;
        movement.z = Input.GetAxisRaw("Vertical") * player_speed;
        if (Input.GetKeyDown(KeyCode.Space))
            movement.y = movement.y + 10;
        rb.velocity = movement;
        
        animator.SetFloat("Speed", rb.velocity.magnitude);  
    }
}

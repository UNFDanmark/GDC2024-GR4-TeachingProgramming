using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float cooldown = 0.2f;
    public float shootingPower = 10f;
    private float cooldownLeft;
    public Animator animator;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        cooldownLeft = cooldownLeft - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F) && cooldownLeft <= 0) {
             GameObject spawnBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
             Rigidbody rigidbodyBullet = spawnBullet.GetComponent<Rigidbody>();
             rigidbodyBullet.velocity = transform.forward * shootingPower;
             cooldownLeft = cooldown;
             
             animator.SetTrigger("Shooting");
             audioSource.Play();
             print("Pew!");
        }
        float input = Input.GetAxisRaw("TurnAround");
        transform.Rotate(0, input, 0);
        
        
    }
}

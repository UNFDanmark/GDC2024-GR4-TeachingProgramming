using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float cooldown = 0.2f;
    public float shootingPower = 5f;
    private float cooldownLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        cooldownLeft = cooldownLeft - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && cooldownLeft <= 0) {
             GameObject spawnBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
             Rigidbody rigidbodyBullet = spawnBullet.GetComponent<Rigidbody>();
             rigidbodyBullet.velocity = transform.forward * shootingPower;
             cooldownLeft = cooldown;
        }
        float input = Input.GetAxisRaw("TurnAround");
        transform.Rotate(0, input, 0);
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletCooldown = 0.3f;

    private float bulletCooldownleft;
    // Start is called before the first frame update
    void Start()
    {
        bulletCooldownleft = bulletCooldown;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        bulletCooldownleft = bulletCooldownleft - Time.deltaTime;
        if (bulletCooldownleft <= 0)
        {
            Destroy(gameObject);

            bulletCooldownleft = bulletCooldownleft;
        }
    }
}

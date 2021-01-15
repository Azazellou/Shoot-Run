using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float cooldown = 0.5f;

    private float cooldownTimer = 0f;
    
    

    // Update is called once per frame
    void Update()
    {
        cooldownTimer += Time.deltaTime;

        // Press space to shoot the bullets 
        if (Input.GetKey (KeyCode.Space) && cooldownTimer >= cooldown)
        {
            Instantiate (bullet, spawnPoint.position, transform.rotation);
            cooldownTimer = 0;

            
        }
    }
}

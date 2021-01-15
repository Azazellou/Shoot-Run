using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private GameObject ProjectileExplosion;

    [SerializeField]
    private GameObject PlayerExplosion;

    private void OnTriggerEnter (Collider other)
    {
        // damage taken by the Bullets
        if (other.tag == "Projectile")
        {
            GameObject expl = Instantiate (ProjectileExplosion, other.transform.position, other.transform.rotation);
            Destroy (expl, 1.0f);

            Life life = GetComponent<Life>();

            if (life != null)
            {
                life.TakeDamage(1);
            }
        }

        // damage taken by the Player 
        if (other.tag == "Player")
        {
            GameObject expl = Instantiate (PlayerExplosion, other.transform.position, other.transform.rotation);
            Destroy (expl, 1.0f);

            Life life = GetComponent<Life>();

            if (life != null)
            {
                life.TakeDamage (100);
            }
        }

        Destroy (other.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Life variables

    [SerializeField]
    private int maxHealth;

    [SerializeField]
    private GameObject explosion;

    private int health;

    private ScoreManagement _scoreManagement;
    

    // Start is called before the first frame update
    void Start()
    {
        _scoreManagement = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreManagement>();
        health = maxHealth;
    }

    // Take damage from bullets
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            var expl = Instantiate (explosion, transform.position, transform.rotation);
            Destroy (expl, 1.0f);
            
            Destroy (gameObject);

            _scoreManagement.IncreaseScore (5);
        }
    }

}

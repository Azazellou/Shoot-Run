using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField]
    private float speed = 100.0f;

    [SerializeField]
    private float rotateSpeed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate left
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Rotate(Vector3.up * (-rotateSpeed * Time.deltaTime));
        }
        // Rotate right 
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
        }
        

        _rigidbody.velocity = transform.rotation * Vector3.left * -speed;
    }
}

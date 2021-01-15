using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFolow : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    [SerializeField]
    public Vector3 defaultDistance;
    
    [SerializeField]
    private float springValue;

    private Vector3 catchupVelocity = Vector3.one;


    // Update is called once per frame
    void LateUpdate()
    {
        if (!target) return;
        {
            Vector3 idealPosition = target.position + (target.rotation * defaultDistance);
            Vector3 currentPosition = Vector3.SmoothDamp(transform.position, idealPosition, ref catchupVelocity, springValue);
            transform.position = currentPosition;
            
            transform.LookAt(target);
        }
    }
}

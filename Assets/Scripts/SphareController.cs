using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SphareController : MonoBehaviour
{
    [Header("Control Settings")]
    [SerializeField]
    private float speed = 1f;
    private Rigidbody rb;
    private bool isRigidbody;
    public float maxAngularVelocity;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        if (isRigidbody = TryGetComponent<Rigidbody>(out rb))
        {
            //debug.log(rb.maxangularvelocity);
            rb.maxAngularVelocity = maxAngularVelocity;
        }
    }

    void Update()
    {
        float HDirection;
        float VDirection;

        if ((HDirection = Input.GetAxis("Horizontal")) != 0 && isRigidbody)
        {
            rb.AddTorque(0, 0, -HDirection * Time.deltaTime * speed);
        }

        if ((VDirection = Input.GetAxis("Vertical")) != 0 && isRigidbody)
        {
            rb.AddTorque(VDirection * Time.deltaTime * speed, 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraController : MonoBehaviour
{
    //public Transform ballTransform;
    public GameObject ballObject;
    public Vector3 distance;
    public float lookUp;
    public float lerpAmount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, ballObject.transform.position + distance, lerpAmount);
        //transform.position = ballObject.transform.position + distance;
        transform.LookAt(ballObject.transform.position);
        transform.Rotate(lookUp, 0, 0);      
    }
}

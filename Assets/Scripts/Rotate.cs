using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 rotationAxis = new Vector3(0, 0, 1);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Step1
        // transform.Rotate(1, 0, 0);

        // Step2
        transform.Rotate(rotationAxis * speed * Time.deltaTime * 100);
    }
}

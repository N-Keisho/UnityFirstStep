using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSC : MonoBehaviour
{
    Rigidbody rb;
    public GameObject goalText;
    public float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        goalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Step1
        // rb.AddForce(new Vector3(-1, 0, 0));

        // Step2
        // if(Input.GetKey(KeyCode.W))
        // {
        //     rb.AddForce(new Vector3(-1, 0, 0));
        // }

        // Step3
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }

        else if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }


        // Step4
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(48,3,0);
            rb.velocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Goal!");
            goalText.SetActive(true);
        }
    }
}

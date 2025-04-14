using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSC : MonoBehaviour
{
    public GameObject ball;
    public Vector3 offset = new Vector3(0, 5, 5);
    void Start()
    {
        
    }

    void Update()
    {
        // 先に子オブジェクトを紹介する
        transform.position = ball.transform.position + offset;
    }
}

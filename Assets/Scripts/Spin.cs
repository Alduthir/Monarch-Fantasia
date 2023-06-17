using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rpm = 5;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,6f * rpm*Time.deltaTime,0);
    }
}

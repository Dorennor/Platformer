using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour
{
    public float size = 30;
    public float speed = 6;
    public static bool state = true;


    void Update()
    {
        if (state)
        {
            transform.position = new Vector3(-(Mathf.Repeat(Time.time * speed, size)), transform.position.y, transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveViking : MonoBehaviour
{
    public static bool isRespawn = false;
    private Transform obj;

    void Start()
    {
        obj = GetComponent<Transform>();
    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (MoveActor.isPlaying)
        {
            obj.position = new Vector2(obj.position.x - 0.1f, obj.position.y);
        }
    }

   
}

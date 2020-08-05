using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVikings : MonoBehaviour
{

    private Rigidbody2D rb;
    public static int numberV = 0;
    private List<Vector2> list = new List<Vector2>(10);

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            list.Add(new Vector2(Random.Range(50f, 75f), Random.Range(-4.5f, -2f)));
        }
        rb = GetComponent<Rigidbody2D>();
    }


void FixedUpdate()
    {
        
        if (numberV < 2 && MoveActor.isPlaying)
        {
            
            Instantiate(rb, list[Random.Range(0, 4)], Quaternion.identity);
            numberV++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            Destroy(gameObject);
            numberV--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveActor : MonoBehaviour
{
    private bool isDead = false;
    public static bool isPlaying = false;
    private Animator anim;
    private Transform obj;

    void Start()
    {
        obj = GetComponent<Transform>();
        anim = GetComponent<Animator>();
	}

    void Pause()
    {
        
    }

    void FixedUpdate()
    {
		if(Input.GetKey(KeyCode.W) && !isDead)
        {
            obj.position = new Vector2(obj.position.x, obj.position.y + 0.1f);
            isPlaying = true;
        }
        if(Input.GetKey(KeyCode.S) && !isDead)
        {
            obj.position = new Vector2(obj.position.x, obj.position.y - 0.1f);
            isPlaying = true;
        }
        if(Input.GetKey(KeyCode.D) && !isDead)
        {
            obj.position = new Vector2(obj.position.x + 0.1f, obj.position.y);
            isPlaying = true;
        }
        if(Input.GetKey(KeyCode.A) && !isDead)
        {
            obj.position = new Vector2(obj.position.x - 0.1f, obj.position.y);
            isPlaying = true;
        }
        anim.SetBool("isRun", isPlaying);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isDead = true;
            Render.state = false;
            anim.SetBool("isDead", true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Fire")
        {
            isDead = true;
            Render.state = false;
            anim.SetBool("isDead", true);
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathViking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            MoveViking.isRespawn = true;
        }
    }



}

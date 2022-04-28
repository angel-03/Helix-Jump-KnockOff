using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public Rigidbody rb;
    public float upForce;
    private bool ignoreNextCollision;
    public GameView gv;
   // public GameManager gm;

    private void OnCollisionEnter(Collision collision)
    {
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;
        if (materialName == "Safe_platform (Instance)")
        {
            if (ignoreNextCollision)
                return;

            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * upForce, ForceMode.Impulse);
            ignoreNextCollision = true;
            Invoke("AllowCollision", .3f);
        }

        else if (materialName == "Unsafe_Platform (Instance)")
        {
           
            gv.gameOver();
            Debug.Log("Game Over");

        }

        else
        {
            Debug.Log("Not Normal");
        }
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        gv.levelCompleted();
    }

    private void AllowCollision()
    {
        ignoreNextCollision = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public static int currentScore;

    public float speed = 20f;
    public Rigidbody2D rb;

    
    void Update()
    {
        //move if is not pinned 
        //move while checking physics
        //2dim vector 
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        

    }


    //hit the rotator and parent it
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            //parent it to rotator
            //stop forward movement and stick

            transform.SetParent(col.transform);
            isPinned = true;
            Score.PinCount++;

        } else if (col.tag == "Pin")
        {

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

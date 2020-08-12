using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D myRigidbody = null;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        float randomNumber = Random.Range(0, 2);
        if(randomNumber <= 0.5)
        {
            Debug.Log("Shoot Right");
            myRigidbody.AddForce(new Vector2(80, 10));
        }
        else
        {
            Debug.Log("Shoot Left");
            myRigidbody.AddForce(new Vector2(-80, -10));
        }
    }

    private void OnCollisionEnter2D(Collision2D colInfo) {
        if(colInfo.collider.tag == "Player")
        {
            Vector3 v = GetComponent<Rigidbody2D>().velocity;
            v.y = myRigidbody.velocity.y/2 + colInfo.collider.attachedRigidbody.velocity.y/3; // addes spin due to paddle
            GetComponent<Rigidbody2D>().velocity = v;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D myRigidbody = null;
    public float ballSpeed = 100f;
    public AudioSource click = null;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        myRigidbody = GetComponent<Rigidbody2D>();
        goBall();
    }

    private void OnCollisionEnter2D(Collision2D colInfo) {
        if(colInfo.collider.tag == "Player")
        {
            Vector3 v = GetComponent<Rigidbody2D>().velocity;
            v.y = myRigidbody.velocity.y/2 + colInfo.collider.attachedRigidbody.velocity.y/3; // addes spin due to paddle
            GetComponent<Rigidbody2D>().velocity = v;
            click.pitch = Random.Range(0.8f, 1.2f);
            click.Play();
        }
    }

    private void goBall()
    {
        float randomNumber = Random.Range(0, 2);
        if(randomNumber <= 0.5)
        {
            Debug.Log("Shoot Right");
            myRigidbody.AddForce(new Vector2(ballSpeed, 10));
        }
        else
        {
            Debug.Log("Shoot Left");
            myRigidbody.AddForce(new Vector2(-ballSpeed, -10));
        }
    }

    IEnumerator ResetBall()
    {
        myRigidbody.velocity = new Vector2(0,0);
        myRigidbody.position = new Vector2(0,0);

        yield return new WaitForSeconds(0.5f);
        goBall();
    }
}
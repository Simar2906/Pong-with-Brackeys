using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    private Rigidbody2D rigbody = null; 
    public float speed = 10f;

    private void Awake() 
    {
        rigbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKey(moveUp))
        {
            rigbody.velocity = new Vector2(0, speed);
        }
        else if(Input.GetKey(moveDown))
        {
            rigbody.velocity = new Vector2(0, speed * -1);
        }
        else
        {
            rigbody.velocity = new Vector2(0, 0);
            
        }
    }

}

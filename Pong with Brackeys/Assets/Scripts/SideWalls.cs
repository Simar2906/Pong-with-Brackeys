using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public AudioSource score = null;
    private void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if(hitInfo.name == "Ball")
        {
            Game_Manager.Score(transform.name);
            hitInfo.gameObject.SendMessage("ResetBall");
            score.Play();
        }
    }
}

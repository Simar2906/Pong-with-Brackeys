using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    static int playerScore01 = 0;
    static int playerScore02 = 0;

    public GUISkin theSkin = null;
    static public void Score(string wallName)
    {
        if(wallName == "rightWall")
        {
            playerScore01 += 1;
        }
        else if(wallName == "leftWall")
        {
            playerScore02 += 1;
        }
        Debug.Log("Player score 1 is :" + playerScore01);
        Debug.Log("Player score 2 is :" + playerScore02);

    }

    private void OnGUI() 
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2 - 150 -12, 25, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2 + 150 -12, 25, 100, 100), "" + playerScore02);
    }
}

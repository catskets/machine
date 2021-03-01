using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerBall; //gives the ball a variable

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerBall.position.x, playerBall.position.y, transform.position.z); //constantly takes position of ball
    }
}

//basic help from https://www.youtube.com/watch?v=VJjD1Tp1I8U
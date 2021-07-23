using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   public enum Direction
   {
        up,down,left,right
   }
    public static Direction dir;

    public static Action PausePressed;
    public static Action AnyKeyPressed;

    private void Update()
    {
    }
    void HandleInputPlaying()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (Mathf.Abs(v) > Mathf.Abs(h))
        {
            dir = v > 0 ? Direction.up : Direction.down;
        }
        else
        {
            dir = h > 0 ? Direction.right : Direction.left;
        }
        if (Input.GetButtonDown("Pause"))
        {
            PausePressed();
        }
    }
    void HandleInputPaused()
    {
        if (Input.GetButtonDown("Pause"))
        {
            PausePressed();
        }
    }
    void HandleInputGameOver()
    {
        if (Input.anyKeyDown)
        {
            AnyKeyPressed();
        }
    }
}

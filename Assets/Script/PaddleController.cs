using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour 
{ 
    public int BaseSpeed; 

    public KeyCode upKey; 
    public KeyCode downKey;
    public int PowerUpTime;

    private Rigidbody2D rig;
    private int speed;
    private bool SpeedUp;
    private bool SizeUp;
    private float TimerSize;
    private float TimerSpeed;
 
    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>();
        speed = BaseSpeed;
        SpeedUp = false;
        SizeUp = false;
    } 
 
    private void Update() 
    { 
        // get input 
        Vector3 movement = GetInput(); 
         
        // move object 
        MoveObject(movement);

        // update untuk power up speed dan timer
        if (SpeedUp == true)
        {
            TimerSpeed += Time.deltaTime;

            if (TimerSpeed > PowerUpTime)
            {
                speed = BaseSpeed;
                SpeedUp = false;
                TimerSpeed -= TimerSpeed;
            }
        }

        if (SizeUp == true)
        {
            TimerSize += Time.deltaTime;

            if (TimerSize > PowerUpTime)
            {
                transform.localScale = new Vector2((float)0.25, (float)2.5);
            }
        }



    } 
 
    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey)) 
        { 
            return Vector2.up * speed; 
        } 
        else if (Input.GetKey(downKey)) 
        { 
            return Vector2.down * speed; 
        } 
         
        return Vector2.zero; 
    } 
    
    // fungsi menggerakkan paddle
    private void MoveObject(Vector2 movement) 
    { 
        
        rig.velocity = movement;
    } 

    // fungsi mengaktifkan power up speed paddle
    public void ActivatePUPaddleSpeed()
    {
        speed *= 2;
        SpeedUp = true;
    }

    //fungsi mengaktifkan power up ukuran paddle
    public void ActivatePUPaddleSize()
    {
        transform.localScale = new Vector2((float)0.25, (float)5);
        SizeUp = true;
    }
} 

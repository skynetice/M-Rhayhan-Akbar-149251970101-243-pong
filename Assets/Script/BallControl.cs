using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;

    public string Paddle = "Square-Right";

    

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    // reset bola setelah goal
     public void ResetBall() 
    { 

        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2); 
    } 

    public void ActivatePUSpeedUp(float magnitude) 
    { 
        rig.velocity *= magnitude; 
    } 

    public void ActivatePUSpeedDown(float magnitude) 
    { 
        rig.velocity /= magnitude; 
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        string lastCollision = collisionInfo.collider.tag;
        string name = collisionInfo.collider.name;
        if (lastCollision == "Player")
        {
            Paddle = name;
            Debug.Log(Paddle);
        }

    }
}

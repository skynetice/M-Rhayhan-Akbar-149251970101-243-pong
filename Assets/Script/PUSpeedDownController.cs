using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedDownController : MonoBehaviour
{
    public Collider2D ball; 
    public float magnitude;
    public PowerUpManager manager; 
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        { 
            ball.GetComponent<BallControl>().ActivatePUSpeedDown(magnitude); //panggil fungsi Speed Up dalam ballcontrol
            manager.RemovePowerUp(gameObject);    // hilangkan objek power up
        }     
    }
}

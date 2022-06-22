using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    private GameObject player;

    // ambil paddle terakhir yang menyentuh bola
    private string WhichPaddle()
    {
        string paddle = ball.GetComponent<BallControl>().Paddle;
        return paddle;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        player = GameObject.Find(WhichPaddle());
        if (collision == ball)
        {
            player.GetComponent<PaddleController>().ActivatePUPaddleSpeed();
            manager.RemovePowerUp(gameObject);
        }
    }
}

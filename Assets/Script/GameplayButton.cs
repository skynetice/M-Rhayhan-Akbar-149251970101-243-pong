using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayButton : MonoBehaviour
{
    // tombol back ke main menu
       
    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

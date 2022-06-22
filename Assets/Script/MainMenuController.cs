using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("Created By Muhammad Rhayhan Akbar - 149251970101-243");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Muhammad Rhayhan Akbar");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour
{
    public string url;


    // tombol back ke main menu
    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void VisitUrl()
    {
        Application.OpenURL(url);
    }
}

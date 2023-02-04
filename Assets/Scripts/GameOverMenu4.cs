using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu4 : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Iphis2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

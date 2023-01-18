using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu2 : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Iphis 1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

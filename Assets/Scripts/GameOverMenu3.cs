using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu3 : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("IphisCompany");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

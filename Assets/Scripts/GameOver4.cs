using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver4 : MonoBehaviour
{
    public bool isTriggered = true;

    void Start()
    {
        if (isTriggered == false)
        {
            if (tag == "Player")
            {
                EndGame();
            }

        }
    }

    public void EndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver4");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") ;
        {
            EndGame();
        }
    }

}
